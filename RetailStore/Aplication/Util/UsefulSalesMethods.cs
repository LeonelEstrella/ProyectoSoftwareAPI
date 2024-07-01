using Application.Interface.ProductInterfaces;
using Application.Interface.SaleMathsInterfaces;
using Application.Interface.SaleProductInterfaces;
using Application.Interface.UsefulSalesMethodsInterfaces;
using Application.Models;
using Application.Response;
using Domain.Entities;
using static Application.Response.AllSaleInformation;

namespace Application.Util
{
    public class UsefulSalesMethods : IUsefulSalesMethods
    {
        const decimal TAXES = 1.21m;
        private readonly IProductService _serviceProduct;
        private readonly ISaleMathematics _saleMathematics;
        private readonly ISaleProductService _saleProductService;

        public UsefulSalesMethods(IProductService serviceProduct, ISaleMathematics saleMathematics, ISaleProductService saleProductService)
        {
            _serviceProduct = serviceProduct;
            _saleMathematics = saleMathematics;
            _saleProductService = saleProductService;
        }

        public async Task<List<AllSaleInformation>> CreateAllProductInformationList(CreateSaleRequest request)
        {
            var totalProductsBougth = 0;

            List<AllSaleInformation> allProductInformationList = new List<AllSaleInformation>();
            ProductGetResponse product;

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

                var singleProduct = new AllSaleInformation.AllSaleInformationSingleSaleProduct
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
                    category = new AllSaleInformationCategoryResponse
                    {
                        id = product.category.id,
                        name = product.category.name
                    },
                    products = new List<AllSaleInformation.AllSaleInformationSingleSaleProduct> { singleProduct }
                });
            }
            return allProductInformationList;
        }

        public Sale CreateSaleEntity(List<AllSaleInformation> allProductInformationList, CreateSaleRequest request)
        {
            Sale sale = new Sale
            {
                Date = DateTime.Now,
                SaleProduct = new List<SaleProduct>()
            };

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

            return sale;
        }

        public List<SingleSaleProduct> GetMappedProducts(int saleId)
        {
            var saledProducts = _saleProductService.GetSaleProductBySaleId(saleId);
            var mappedProducts = new List<SingleSaleProduct>();

            foreach (var saleProduct in saledProducts)
            {
                var singleSaleProduct = new SingleSaleProduct
                {
                    id = saleProduct.ShoppingCartId,
                    productId = saleProduct.Product,
                    quantity = saleProduct.Quantity,
                    price = saleProduct.Price,
                    discount = saleProduct.Discount
                };

                mappedProducts.Add(singleSaleProduct);
            }

            return mappedProducts;
        }
    }
}
