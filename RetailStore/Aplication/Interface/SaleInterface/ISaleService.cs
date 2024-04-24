using Application.Models;
using Application.Response;
using Domain.Entities;

namespace Application.Interface.SaleInterface
{
    public interface ISaleService
    {
        Task<List<SingleSaleResponse>> GetSalesList(string from, string to);
        Task<SingleSaleResponse> CreateSale(CreateSaleRequest request);
        Task<SingleSaleResponse> GetSaleById(int saleId);
    }
}
