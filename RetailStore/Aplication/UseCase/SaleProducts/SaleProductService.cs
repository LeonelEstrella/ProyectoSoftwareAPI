using Application.Interface.SaleProductInterfaces;
using Domain.Entities;

namespace Application.UseCase.SaleProducts
{
    public class SaleProductService : ISaleProductService
    {
        private readonly ISaleProductQuery _query;

        public SaleProductService(ISaleProductQuery query)
        {
            _query = query;
        }

        public async Task<List<SaleProduct>> GetSaleProductBySaleId(int saleId)
        {
            var saleProductList = _query.GetSaleProductById(saleId);
            return saleProductList;
        }

        public bool WasProductSale(Guid productId)
        {
            return _query.ProductExistInSale(productId);
        }
    }
}
