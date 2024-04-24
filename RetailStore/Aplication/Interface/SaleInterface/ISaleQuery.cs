using Domain.Entities;

namespace Application.Interface.SaleInterface
{
    public interface ISaleQuery
    {
        List<Sale> GetSales(string from, string to);
        Sale GetSaleById(int saleId);
    }
}
