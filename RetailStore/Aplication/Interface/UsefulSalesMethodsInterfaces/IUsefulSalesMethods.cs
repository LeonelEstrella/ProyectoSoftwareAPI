using Application.Models;
using Application.Response;
using Domain.Entities;

namespace Application.Interface.UsefulSalesMethodsInterfaces
{
    public interface IUsefulSalesMethods
    {
        Task<List<AllSaleInformation>> CreateAllProductInformationList(CreateSaleRequest request);

        Sale CreateSaleEntity(List<AllSaleInformation> allProductInformationList, CreateSaleRequest request);

        List<SingleSaleProduct> GetMappedProducts(int saleId);
    }
}
