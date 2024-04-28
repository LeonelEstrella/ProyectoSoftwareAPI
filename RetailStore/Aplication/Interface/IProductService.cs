using Application.Models;
using Application.Response;
using Domain.Entities;

namespace Application.Interface
{
    public interface IProductService
    {
        Task<ProductGetResponse> CreateProduct(ProductRequest request);
        Task<ProductGetResponse> UpdateProduct(Guid productId, ProductRequest request);
        List<ProductListResponse> GetProductList(List<int> categories, string name, int skip, int limit);
        Task<ProductGetResponse> GetProductById(Guid productId);
        Task<ProductGetResponse> DeleteProductById(Guid productId); 
    }
}
