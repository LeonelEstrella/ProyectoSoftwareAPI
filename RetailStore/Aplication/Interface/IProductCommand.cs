using Domain.Entities;

namespace Application.Interface
{
    public interface IProductCommand
    {
        Task InsertProduct(Product product);
        Task RemoveProduct(Product product);
        Task PatchProduct(Product product);
    }
}
