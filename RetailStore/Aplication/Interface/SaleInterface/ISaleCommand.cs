using Application.Response;
using Domain.Entities;

namespace Application.Interface.SaleInterface
{
    public interface ISaleCommand
    {
       int RegisterSale(IList<ProductResponse> productList, Sale sale);
    }
}
