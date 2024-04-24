using Application.Models;
using Application.Response;

namespace Application.Interface.SaleInterface
{
    public interface ISaleService
    {
        List<SalesListResponse> GetSalesList(string from, string to);
        Task<SingleSaleResponse> CreateSale(CreateSaleRequest request);
        Task<SingleSaleResponse> GetSaleById(int saleId);
    }
}
