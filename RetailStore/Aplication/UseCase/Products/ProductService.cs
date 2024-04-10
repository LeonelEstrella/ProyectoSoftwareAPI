using Aplication.Interface;
using Aplication.Interface.Categories;
using Aplication.Models;
using Aplication.Response;
using Aplication.UseCase.Categories;
using Domain.Entities;

namespace Aplication.UseCase.Products
{
    public class ProductService : IProductService
    {
        private readonly IProductCommand _command;
        private readonly IProductQuery _query;
        private readonly ICategoryService _categoryService;

        public ProductService(IProductCommand command, IProductQuery query, ICategoryService categoryService)
        {
            _command = command;
            _query = query;
            _categoryService = categoryService;
        }

        public async Task<ProductResponse> CreateProduct(CreateProductRequest request)
        {
            var product = new Product {ProductId = new Guid() ,Name = request.ProductName, Description = request.ProductDescription, Price = request.ProductPrice, Discount = request.ProductDiscount, CategoryId = request.CategoryCategoryId, ImageLink = request.ProductImageLink};
            await _command.InsertProduct(product);

            return new ProductResponse
            {
                ProductId = product.ProductId,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                Discount = product.Discount,
                CategoryName = _categoryService.GetCategoryById(product.CategoryId),
                ImageLink = product.ImageLink
            };
        }

        public Task<Product> DeleteProductById(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<ProductResponse> GetProductById(Guid productId)
        {
            var product = _query.GetProductById(productId);
            return Task.FromResult(new ProductResponse
            {
                ProductId = product.ProductId,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                Discount = product.Discount,
                CategoryName = _categoryService.GetCategoryById(product.CategoryId),
                ImageLink = product.ImageLink
            });
        }

        public Task<List<Product>> GetProductList()
        {
            throw new NotImplementedException();
        }

        public Task<Product> UpdateProduct(int productId)
        {
            throw new NotImplementedException();
        }
    }
}
