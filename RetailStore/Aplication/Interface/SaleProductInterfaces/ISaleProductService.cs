using Domain.Entities;

namespace Application.Interface.SaleProductInterfaces
{
    public interface ISaleProductService
    {
        List<SaleProduct> GetSaleProductBySaleId(int saleId);
        Boolean WasProductSale(Guid productId);
    }
}
