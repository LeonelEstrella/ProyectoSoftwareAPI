using Application.Interface;
using Application.Interface.SaleInterface;
using Application.Interface.SaleMaths;
using Application.Models;
using Application.Response;
using Application.Util;
using Domain.Entities;

namespace Application.UseCase.Sale
{
    public class SaleService : ISaleService
    {
        const decimal TAXES = 1.21m;
        private readonly ISaleCommand _command;
        private readonly ISaleQuery _query;
        private readonly IProductService _serviceProduct;
        private readonly IList<ProductResponse> _productList;
        private  Domain.Entities.Sale _sale;
        private readonly ISaleMathematics _saleMathematics;

        public SaleService(ISaleCommand command, ISaleQuery query, IProductService service, IList<ProductResponse> productList, Domain.Entities.Sale sale, ISaleMathematics saleMathematics)
        {
            _command = command;
            _query = query;
            _serviceProduct = service;
            _productList = productList;
            _sale = sale;
            _saleMathematics = saleMathematics;
        }

        public async Task<SingleSaleResponse> CreateSale(CreateSaleRequest request)
        {
            var totalProductsBougth = 0;
            var productListResponse = new List<SingleSaleProduct>();
            ProductResponse product;

            foreach (var item in request.products) 
            {
                totalProductsBougth += item.quantity;

                if (item.quantity <= 0)
                {
                    throw new BadRequestException("La cantidad del producto debe ser mayor que 0.");
                }

                try 
                {
                    product = await _serviceProduct.GetProductById(item.productId);
                }

                catch (Exception ex) 
                {
                    throw new BadRequestException("No se pudo crear la venta. Por favor, revise los datos proporcionados.");
                }
                             

                _productList.Add(new ProductResponse 
                {
                    id = product.id,
                    name = product.name,
                    description = product.description,
                    price = product.price,
                    discount = product.discount,
                    imageUrl = product.imageUrl,
                    quantity = item.quantity,
                    category = new ProductCategoryResponse
                    {
                        id = product.category.id,
                        name = product.category.name
                    }
                });

                productListResponse.Add(new SingleSaleProduct
                {
                    productId = product.id,
                    quantity = item.quantity,
                    price = product.price,
                    discount = product.discount
                });
            }

            _sale = _saleMathematics.CalculateSale(_productList, _sale);

            var saleId = _command.RegisterSale(_productList, _sale);

            return await Task.FromResult(new SingleSaleResponse
            {
                id = saleId,
                totalPay = _sale.TotalPay,
                totalQuantity = totalProductsBougth,
                subtotal = _sale.Subtotal,
                totalDiscount = _sale.TotalDiscount,
                taxes = TAXES,
                date = DateTime.Now,
                products = productListResponse
            });
        }

        public async Task<SingleSaleResponse> GetSaleById(int saleId)
        {
            var currentSale = _query.GetSaleById(saleId);          

            if (currentSale == null)
            {
                throw new NotFoundException($"No se ha encontrado la venta.");
            }

            return await Task.FromResult(new SingleSaleResponse
            {
                id = currentSale.SaleId,
                totalPay = currentSale.TotalPay,
                totalQuantity = 0,
                subtotal = currentSale.Subtotal,
                taxes = currentSale.Taxes,
                date = currentSale.DateTime,
                //products = currentSale.SaleProductList

            });
        }

        public Task<List<SingleSaleResponse>> GetSalesList(string from, string to)
        {
            throw new NotImplementedException();
        }
    }
}
