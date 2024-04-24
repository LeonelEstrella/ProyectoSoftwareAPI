using Application.Response;
using Domain.Entities;

namespace Application.Interface.SaleMaths
{
    public interface ISaleMathematics
    {
        public Sale CalculateSale(IList<ProductResponse> productList, Sale saleInformation);
    }
}
