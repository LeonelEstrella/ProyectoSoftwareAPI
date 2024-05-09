using Application.Interface.ProductInterfaces;
using Application.Interface.SaleInterfaces;
using Application.Interface.SaleMathsInterfaces;
using Application.Interface.SaleProductInterfaces;
using Application.Models;
using Application.Response;
using Application.Util;
using Domain.Entities;
using System.Globalization;

namespace Application.UseCase.Sale
{
    public class SaleService : ISaleService
    {
        const decimal TAXES = 1.21m;
        private readonly ISaleCommand _command;
        private readonly ISaleQuery _query;
        private readonly IProductService _serviceProduct;
        private readonly IList<SingleSaleProduct> _singleSaleProduct;
        private readonly ISaleMathematics _saleMathematics;
        private readonly ISaleProductService _saleProductService;

        public SaleService(ISaleCommand command, ISaleQuery query, IProductService service, ISaleMathematics saleMathematics, IList<SingleSaleProduct> singleSaleProduct, ISaleProductService saleProductService)
        {
            _command = command;
            _query = query;
            _serviceProduct = service;
            _saleMathematics = saleMathematics;
            _singleSaleProduct = singleSaleProduct;
            _saleProductService = saleProductService;
        }

        public async Task<SingleSaleResponse> CreateSale(CreateSaleRequest request)
        {

            var totalProductsBougth = 0;

            List<AllSaleInformation> allProductInformationList = new List<AllSaleInformation>();
            ProductGetResponse product;

            Domain.Entities.Sale sale = new Domain.Entities.Sale
            {
                Date = DateTime.Now,
                SaleProduct = new List<SaleProduct>()
            };

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

                var singleProduct = new AllSaleInformation.SingleSaleProduct
                {
                    productId = product.id,
                    quantity = item.quantity,
                    price = product.price,
                    discount = product.discount
                };

                allProductInformationList.Add(new AllSaleInformation
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
                    },
                    products = new List<AllSaleInformation.SingleSaleProduct> { singleProduct }
                });
            }

            var total = _saleMathematics.CalculateSale(allProductInformationList);

            decimal roundedSale = Math.Round(total.TotalPay, 2);
            decimal requestTotal = Math.Round(request.totalPayed, 2);

            if (Convert.ToDouble(requestTotal) != Convert.ToDouble(roundedSale))
            {
                throw new BadRequestException("No se pudo crear la venta. Por favor, revise los datos proporcionados.");
            }


            foreach (var item in allProductInformationList)
            {
                sale.SaleProduct.Add(new SaleProduct
                {
                    Product = item.id,
                    Quantity = item.quantity,
                    Price = item.price,
                    Discount = item.discount
                });
            }
            sale.Subtotal = total.Subtotal;
            sale.TotalDiscount = total.TotalDiscount;
            sale.Taxes = TAXES;
            sale.TotalPay = total.TotalPay;

            var saleId = await _command.RegisterSale(sale);

            var saledProducts = _saleProductService.GetSaleProductBySaleId(saleId);
            var mappedProducts = new List<Application.Response.SingleSaleProduct>();

            for (int i = 0; i < saledProducts.Count; i++)
            {

                var singleSaleProduct = new Application.Response.SingleSaleProduct
                {
                    id = saledProducts[i].ShoppingCartId,
                    productId = saledProducts[i].Product,
                    quantity = saledProducts[i].Quantity,
                    price = saledProducts[i].Price,
                    discount = saledProducts[i].Discount
                };

                mappedProducts.Add(singleSaleProduct);
            }
            

            return await Task.FromResult(new SingleSaleResponse
            {
                id = saleId,
                totalPay = sale.TotalPay,
                totalQuantity = totalProductsBougth,
                subtotal = sale.Subtotal,
                totalDiscount = sale.TotalDiscount,
                taxes = TAXES,
                date = sale.Date,
                products = mappedProducts
            });
        }

        public async Task<SingleSaleResponse> GetSaleById(int saleId)
        {
            var totalProductsBougth = 0;
            var currentSale = await _query.GetSaleById(saleId);          

            if (currentSale == null)
            {
                throw new NotFoundException("No se ha encontrado la venta.");
            }
            
            var productIdList = _saleProductService.GetSaleProductBySaleId(saleId);


            foreach (var item in productIdList )
            {
                var product = (await _serviceProduct.GetProductById(item.Product));
                totalProductsBougth += item.Quantity;
                _singleSaleProduct.Add(new SingleSaleProduct
                {
                    id = item.ShoppingCartId,
                    productId = product.id,
                    quantity = item.Quantity,
                    price = product.price,
                    discount = product.discount
                });
            }

            return await Task.FromResult(new SingleSaleResponse
            {
                id = currentSale.SaleId,
                totalPay = currentSale.TotalPay,
                totalQuantity = totalProductsBougth,
                subtotal = currentSale.Subtotal,
                totalDiscount = currentSale.TotalDiscount,
                taxes = currentSale.Taxes,
                date = currentSale.Date,
                products = _singleSaleProduct.ToList()

            });
        }

        public List<SalesListResponse> GetSalesList(DateTime? from, DateTime? to)
        {
            DateTime? fromDate = null;
            DateTime? toDate = null;

            if (from.HasValue)
            {
                if (!DateTime.TryParseExact(from.Value.ToString("yyyy-MM-dd"), "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out var parsedFrom))
                {
                    throw new BadRequestException("La fecha de inicio no tiene el formato correcto (yyyy-MM-dd).");
                }
                fromDate = parsedFrom;
            }

            if (to.HasValue)
            {
                if (!DateTime.TryParseExact(to.Value.ToString("yyyy-MM-dd"), "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out var parsedTo))
                {
                    throw new BadRequestException("La fecha de fin no tiene el formato correcto (yyyy-MM-dd).");
                }
                toDate = parsedTo;
            }

            if(fromDate > toDate)
            {
                throw new BadRequestException("La fecha de inicio no puede ser mayor a la fecha de fin.");
            }

            var salesList = _query.GetSales(fromDate, toDate);

            List<SalesListResponse> salesListResponse = new List<SalesListResponse>();

            foreach (var item in salesList)
            {
                int totalProductsSaled = 0;

                var productList = _saleProductService.GetSaleProductBySaleId(item.SaleId);

                foreach (var product in productList)
                {
                    totalProductsSaled += product.Quantity;
                }

                salesListResponse.Add(new SalesListResponse
                {
                    id = item.SaleId,
                    totalPay = item.TotalPay,
                    totalQuantity = totalProductsSaled,
                    date = item.Date
                });
            }

            return salesListResponse;

        }
    }
}
