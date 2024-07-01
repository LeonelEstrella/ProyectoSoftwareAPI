using Application.Models;
using Application.Response;

namespace Application.Interface.SaleInterfaces
{
    public interface ISaleService
    {
        List<SalesListResponse> GetSalesList(DateTime? from, DateTime? to);
        Task<SingleSaleResponse> CreateSale(CreateSaleRequest request);
        Task<SingleSaleResponse> GetSaleById(int saleId);
    }
}
