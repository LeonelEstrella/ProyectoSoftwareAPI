using Domain.Entities;

namespace Application.Interface.SaleInterface
{
    public interface ISaleQuery
    {
        List<Sale> GetSales(DateTime? fromDate, DateTime? toDate);
        Task<Sale> GetSaleById(int saleId);
    }
}
