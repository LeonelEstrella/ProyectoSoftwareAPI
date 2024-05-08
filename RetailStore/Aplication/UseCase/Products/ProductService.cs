using Application.Interface;
using Application.Interface.Categories;
using Application.Interface.SaleProductInterfaces;
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
        private readonly ISaleProductService _saleProductService;

        public ProductService(IProductCommand command, IProductQuery query, ICategoryService categoryService, ISaleProductService saleProductService)
        {
            _command = command;
            _query = query;
            _categoryService = categoryService;
            _saleProductService = saleProductService;
        }

        public async Task<ProductGetResponse> CreateProduct(ProductRequest request)
        {
            if (request.discount < 0 || request.discount >= 100 || request.price <= 0 || string.IsNullOrEmpty(request.name))
            {
                throw new BadRequestException("No se pudo crear el producto. Por favor, revise los datos proporcionados.");
            }

            var existingProduct = await _query.GetProductByName(request.name);
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
                    Price = Convert.ToDecimal(request.price),
                    Discount = request.discount,
                    Category = request.category,
                    ImageUrl = request.imageUrl
                };

                await _command.InsertProduct(product);

                var categoryObject = await _categoryService.GetCategoryById(product.Category);

                int? discountValue = request.discount.HasValue ? request.discount.Value : null;

                string? imageUrlValue = request.imageUrl != null ? request.imageUrl : null;

                string? descriptionValue = request.description != null ? request.description : null;

                return new ProductGetResponse
                {
                    id = product.ProductId,
                    name = product.Name,
                    description = descriptionValue,
                    price = product.Price,
                    discount = discountValue,
                    imageUrl = imageUrlValue,
                    category = new ProductCategoryResponse
                    {
                        id = categoryObject.CategoryId,
                        name = categoryObject.Name,
                    }
                };
            }
           
            catch (Exception ex) 
            {
                throw new BadRequestException("No se pudo crear el producto. Por favor, revise los datos proporcionados.");
            }
        }

        public async Task<ProductGetResponse> DeleteProductById(Guid productId)
        {
            var product = await _query.GetProductById(productId);

            if (product == null)
            {
                throw new NotFoundException($"No se ha encontrado el producto.");
            }

            if (_saleProductService.WasProductSale(productId)) 
            {
                throw new ConflictException($"No se puede borrar este producto porque se encuentra asociado a una venta.");
            }

            await _command.RemoveProduct(product);

            var categoryObject = await _categoryService.GetCategoryById(product.Category);

            int? discountValue = product.Discount.HasValue ? product.Discount.Value : null;

            string? imageUrlValue = product.ImageUrl != null ? product.ImageUrl : null;

            string? descriptionValue = product.Description != null ? product.Description : null;

            return await Task.FromResult(new ProductGetResponse
            {
                id = product.ProductId,
                name = product.Name,
                description = descriptionValue,
                price = product.Price,
                discount = discountValue,
                imageUrl = imageUrlValue,
                category = new ProductCategoryResponse
                {
                    id = categoryObject.CategoryId,
                    name = categoryObject.Name,
                }
            });
        }

        public async Task<ProductGetResponse> GetProductById(Guid productId)
        {
            var product = await _query.GetProductById(productId);

            if (product == null)
            {
                throw new NotFoundException("No se ha encontrado el producto.");
            }

            int? discountValue = product.Discount.HasValue ? product.Discount.Value : null;

            string? imageUrlValue = product.ImageUrl != null ? product.ImageUrl : null;

            string? descriptionValue = product.Description != null ? product.Description : null;

            var categoryObject = await _categoryService.GetCategoryById(product.Category);

            return await Task.FromResult(new ProductGetResponse
            {
                id = product.ProductId,
                name = product.Name,
                description = descriptionValue,
                price = product.Price,
                discount = discountValue,
                imageUrl = imageUrlValue,
                category = new ProductCategoryResponse
                {
                    id = categoryObject.CategoryId,
                    name = categoryObject.Name,
                }
            });
        }

        public async Task<List<ProductListResponse>> GetProductList(List<int> categories, string name, int offset, int limit)
        {
            var productsList =  _query.GetAllProducts(categories, name, offset, limit);

            List<ProductListResponse> productListResponse = new List<ProductListResponse>();

            foreach (var item in productsList)
            {
                var categoryObject = await _categoryService.GetCategoryById(item.Category);

                decimal? discountValue = item.Discount.HasValue ? item.Discount.Value : null;

                string? imageUrlValue = item.ImageUrl != null ? item.ImageUrl : null;

                productListResponse.Add(new ProductListResponse 
                { 
                    id = item.ProductId,
                    name = item.Name,
                    price = item.Price,
                    discount = discountValue,
                    imageUrl = imageUrlValue,
                    categoryName = categoryObject.Name
                });
            }

            return productListResponse;
        }

        public async Task<ProductGetResponse> UpdateProduct(Guid productId, ProductRequest request)
        {
            var currentProduct = await _query.GetProductById(productId);

            if (currentProduct == null)
            {
                throw new NotFoundException("No se ha encontrado el producto.");
            }

            if (request.discount < 0 || request.discount >= 100 || request.price <= 0 || string.IsNullOrEmpty(request.name))
            {
                throw new BadRequestException("No se pudo actualizar el producto. Por favor, revise los datos proporcionados.");
            }

            var sameProductWithDifferentId = await _query.GetProductByNameAndId(request.name, productId);

            if (sameProductWithDifferentId != null)
            {
                throw new ConflictException($"Ya existe un producto con el nombre '{request.name}' en el ID: '{sameProductWithDifferentId.ProductId}'.");
            }

            try
            {
                currentProduct.Name = request.name;
                currentProduct.Description = request.description;
                currentProduct.Price = Convert.ToDecimal(request.price);
                currentProduct.Discount = request.discount;
                currentProduct.Category = request.category;
                currentProduct.ImageUrl = request.imageUrl;

                await _command.PutProduct(currentProduct);

                var categoryObject = await _categoryService.GetCategoryById(currentProduct.Category);

                int? discountValue = request.discount.HasValue ? request.discount.Value : null;

                string? imageUrlValue = request.imageUrl != null ? request.imageUrl : null;

                string? descriptionValue = request.description != null ? request.description : null;

                return new ProductGetResponse
                {
                    id = productId,
                    name = currentProduct.Name,
                    description = descriptionValue,
                    price = currentProduct.Price,
                    discount = discountValue,
                    imageUrl = imageUrlValue,
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
