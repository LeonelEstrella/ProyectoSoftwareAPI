using Application.Response;
using Domain.Entities;

namespace Application.Interface.SaleMathsInterfaces
{
    public interface ISaleMathematics
    {
        public Sale CalculateSale(IList<AllSaleInformation> productList);
    }
}
