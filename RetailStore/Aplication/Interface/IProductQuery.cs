using Domain.Entities;

namespace Application.Interface
{
    public interface IProductQuery
    {
        List<Product> GetAllProducts(List<int> categories, string name, int skip, int limit);
        Product GetProductById(Guid productId);
        Product GetProductByName(string name);
        Product GetProductByNameAndId(string name, Guid productId);
    }
}
