using Domain.Entities;

namespace Aplication.Interface
{
    public interface IProductCommand
    {
        Task InsertProduct(Product product);
        Task RemoveProduct(int productId);
    }
}
