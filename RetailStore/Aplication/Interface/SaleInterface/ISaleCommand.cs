using Application.Response;
using Domain.Entities;

namespace Application.Interface.SaleInterface
{
    public interface ISaleCommand
    {
       Task<int> RegisterSale(IList<SaleProductResponse> productList, Sale sale);
    }
}
