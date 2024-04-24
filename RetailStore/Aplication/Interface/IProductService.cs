using Application.Models;
using Application.Response;
using Domain.Entities;

namespace Application.Interface
{
    public interface IProductService
    {
        Task<ProductResponse> CreateProduct(CreateProductRequest request);
        Task<ProductResponse> UpdateProduct(Guid productId, CreateProductRequest request);
        List<ProductListResponse> GetProductList(List<int> categories, string name, int skip, int limit);
        Task<ProductResponse> GetProductById(Guid productId);
        Task<ProductResponse> DeleteProductById(Guid productId); 
    }
}
