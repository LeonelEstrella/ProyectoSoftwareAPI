using Domain.Entities;

namespace Application.Interface
{
    public interface IProductQuery
    {
        List<Product> GetProductList();
        Product GetProductById(Guid productId);
    }
}
