using Application.Models;
using Application.Response;

namespace Application.Interface.ProductInterfaces
{
    public interface IProductService
    {
        Task<ProductGetResponse> CreateProduct(ProductRequest request);
        Task<ProductGetResponse> UpdateProduct(Guid productId, ProductRequest request);
        Task<List<ProductListResponse>> GetProductList(List<int> categories, string name, int offset, int limit);
        Task<ProductGetResponse> GetProductById(Guid productId);
        Task<ProductGetResponse> DeleteProductById(Guid productId);
    }
}
