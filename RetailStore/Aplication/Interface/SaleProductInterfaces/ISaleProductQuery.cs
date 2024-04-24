using Domain.Entities;

namespace Application.Interface.SaleProductInterfaces
{
    public interface ISaleProductQuery
    {
        List<SaleProduct> GetSaleProductById(int saleId);
        Boolean ProductExistInSale(Guid productId);
    }
}
