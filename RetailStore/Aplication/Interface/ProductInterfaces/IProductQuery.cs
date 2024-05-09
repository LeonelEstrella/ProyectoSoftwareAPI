using Domain.Entities;

namespace Application.Interface.ProductInterfaces
{
    public interface IProductQuery
    {
        List<Product> GetAllProducts(List<int> categories, string name, int skip, int limit);
        Task<Product> GetProductById(Guid productId);
        Task<Product> GetProductByName(string name);
        Task<Product> GetProductByNameAndId(string name, Guid productId);
    }
}
