using Domain.Entities;

namespace Application.Interface.SaleInterface
{
    public interface ISaleQuery
    {
        List<Sale> GetSales(DateTime? fromDate, DateTime? toDate);
        Sale GetSaleById(int saleId);
    }
}
