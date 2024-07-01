using Application.Interface.ProductInterfaces;
using Application.Interface.SaleInterfaces;
using Application.Interface.SaleProductInterfaces;
using Application.Interface.UsefulSalesMethodsInterfaces;
using Application.Models;
using Application.Response;
using Application.Util;
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
        private readonly ISaleProductService _saleProductService;
        private readonly IUsefulSalesMethods _usefulSalesMethods;

        public SaleService(ISaleCommand command, ISaleQuery query, IProductService service, IList<SingleSaleProduct> singleSaleProduct, ISaleProductService saleProductService, IUsefulSalesMethods usefulSalesMethods)
        {
            _command = command;
            _query = query;
            _serviceProduct = service;
            _singleSaleProduct = singleSaleProduct;
            _saleProductService = saleProductService;
            _usefulSalesMethods = usefulSalesMethods;
        }

        public async Task<SingleSaleResponse> CreateSale(CreateSaleRequest request)
        {

            var allProductInformationList = await _usefulSalesMethods.CreateAllProductInformationList(request);

            var sale = _usefulSalesMethods.CreateSaleEntity(allProductInformationList, request);

            var saleId = await _command.RegisterSale(sale);

            var mappedProducts = _usefulSalesMethods.GetMappedProducts(saleId);

            return await Task.FromResult(new SingleSaleResponse
            {
                id = saleId,
                totalPay = sale.TotalPay,
                totalQuantity = allProductInformationList.Sum(p => p.quantity),
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
