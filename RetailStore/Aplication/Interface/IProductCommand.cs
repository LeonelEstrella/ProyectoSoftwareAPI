using Domain.Entities;

namespace Application.Interface
{
    public interface IProductCommand
    {
        Task InsertProduct(Product product);
        Task RemoveProduct(Product product);
        Task PutProduct(Product product);
    }
}
