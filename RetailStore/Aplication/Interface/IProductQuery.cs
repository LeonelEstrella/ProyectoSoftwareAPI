using Domain.Entities;

namespace Aplication.Interface
{
    public interface IProductQuery
    {
        List<Product> GetProductList();
        Product GetProductById(Guid productId);
    }
}
