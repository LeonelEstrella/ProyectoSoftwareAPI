using Aplication.Models;
using Aplication.Response;
using Domain.Entities;

namespace Aplication.Interface
{
    public interface IProductService
    {
        Task<ProductResponse> CreateProduct(CreateProductRequest request);
        Task<Product> UpdateProduct(int productId);
        Task<List<Product>> GetProductList();
        Task<ProductResponse> GetProductById(Guid productId);
        Task<Product> DeleteProductById(int productId); 
    }
}
