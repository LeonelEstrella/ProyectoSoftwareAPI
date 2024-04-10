using Application.Models;
using Application.Response;
using Domain.Entities;

namespace Application.Interface
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
