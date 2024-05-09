using Application.Response;
using Domain.Entities;

namespace Application.Interface.SaleInterfaces
{
    public interface ISaleCommand
    {
       Task<int> RegisterSale( Sale sale);
    }
}
