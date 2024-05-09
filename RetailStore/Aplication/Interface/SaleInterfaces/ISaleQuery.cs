using Domain.Entities;

namespace Application.Interface.SaleInterfaces
{
    public interface ISaleQuery
    {
        List<Sale> GetSales(DateTime? fromDate, DateTime? toDate);
        Task<Sale> GetSaleById(int saleId);
    }
}
