using Domain.Entities;

namespace Application.Interface.SaleProductInterfaces
{
    public interface ISaleProductService
    {
        Task<List<SaleProduct>> GetSaleProductBySaleId(int saleId);
        Boolean WasProductSale(Guid productId);
    }
}
