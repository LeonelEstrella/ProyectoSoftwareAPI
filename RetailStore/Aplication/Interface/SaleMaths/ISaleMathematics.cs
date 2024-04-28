using Application.Response;
using Domain.Entities;

namespace Application.Interface.SaleMaths
{
    public interface ISaleMathematics
    {
        public Sale CalculateSale(IList<ProductGetResponse> productList, Sale saleInformation);
    }
}
