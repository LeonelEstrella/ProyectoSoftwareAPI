using Application.Interface;
using Application.Interface.Categories;
using Application.Models;
using Application.Response;
using Application.Util;
using Domain.Entities;

namespace Application.UseCase.Products
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

            var existingProduct = _query.GetProductByName(request.name);
            if (existingProduct != null)
            {
                throw new ConflictException($"Ya existe un producto con el nombre '{request.name}'.");
            }

            try 
            {
                var product = new Product
                {
                    ProductId = new Guid(),
                    Name = request.name,
                    Description = request.description,
                    Price = request.price,
                    Discount = request.discount,
                    CategoryId = request.category,
                    ImageLink = request.imageUrl
                };

                await _command.InsertProduct(product);

                var categoryObject = _categoryService.GetCategoryById(product.CategoryId);

                return new ProductResponse
                {
                    id = product.ProductId,
                    name = product.Name,
                    description = product.Description,
                    price = product.Price,
                    discount = product.Discount,
                    imageUrl = product.ImageLink,
                    category = new ProductCategoryResponse
                    {
                        id = categoryObject.CategoryId,
                        name = categoryObject.Name,
                    }
                };
            }
           
            catch (Exception ex) 
            {
                throw new BadRequestException("No se pudo crear el producto. Por favor, revise los datos proporcionados.", ex);
            }
        }

        public async Task<ProductResponse> DeleteProductById(Guid productId)
        {
            var product = _query.GetProductById(productId);

            if (product == null)
            {
                throw new NotFoundException($"No se ha encontrado el producto.");
            }

            await _command.RemoveProduct(product);

            var categoryObject = _categoryService.GetCategoryById(product.CategoryId);

            return await Task.FromResult(new ProductResponse
            {
                id = product.ProductId,
                name = product.Name,
                description = product.Description,
                price = product.Price,
                discount = product.Discount,
                imageUrl = product.ImageLink,
                category = new ProductCategoryResponse
                {
                    id = categoryObject.CategoryId,
                    name = categoryObject.Name,
                }
            });
        }

        public async Task<ProductResponse> GetProductById(Guid productId)
        {
            var product = _query.GetProductById(productId);

            if (product == null)
            {
                throw new NotFoundException($"No se ha encontrado el producto.");
            }

            var categoryObject = _categoryService.GetCategoryById(product.CategoryId);

            return await Task.FromResult(new ProductResponse
            {
                id = product.ProductId,
                name = product.Name,
                description = product.Description,
                price = product.Price,
                discount = product.Discount,
                imageUrl = product.ImageLink,
                category = new ProductCategoryResponse
                {
                    id = categoryObject.CategoryId,
                    name = categoryObject.Name,
                }
            });
        }

        public List<ProductListResponse> GetProductList(List<int> categories, string name, int skip, int limit)
        {
            var productsList = _query.GetAllProducts(categories, name, skip, limit);

            List<ProductListResponse> productListResponse = new List<ProductListResponse>();

            foreach (var item in productsList)
            {
                var categoryObject = _categoryService.GetCategoryById(item.CategoryId);

                productListResponse.Add(new ProductListResponse 
                { 
                    id = item.ProductId,
                    name = item.Name,
                    price = item.Price,
                    discount = item.Discount,
                    imageUrl = item.ImageLink,
                    categoryName = categoryObject.Name
                });
            }

            return productListResponse;
        }

        public async Task<ProductResponse> UpdateProduct(Guid productId, CreateProductRequest request)
        {
            var currentProduct = _query.GetProductById(productId);

            if (currentProduct == null)
            {
                throw new NotFoundException($"No se ha encontrado el producto.");
            }

            if (currentProduct.Name == request.name)
            {
                throw new ConflictException($"Ya existe un producto con el nombre '{request.name}'.");
            }

            try
            {
                currentProduct.Name = request.name;
                currentProduct.Description = request.description;
                currentProduct.Price = request.price;
                currentProduct.Discount = request.discount;
                currentProduct.CategoryId = request.category;
                currentProduct.ImageLink = request.imageUrl;

                await _command.PatchProduct(currentProduct);

                var categoryObject = _categoryService.GetCategoryById(currentProduct.CategoryId);

                return new ProductResponse
                {
                    id = productId,
                    name = currentProduct.Name,
                    description = currentProduct.Description,
                    price = currentProduct.Price,
                    discount = currentProduct.Discount,
                    imageUrl = currentProduct.ImageLink,
                    category = new ProductCategoryResponse
                    {
                        id = categoryObject.CategoryId,
                        name = categoryObject.Name,
                    }
                };
            }

            catch (Exception ex)
            {
                throw new BadRequestException("No se pudo actualizar el producto. Por favor, revise los datos proporcionados.", ex);
            }
        }
    }
}
