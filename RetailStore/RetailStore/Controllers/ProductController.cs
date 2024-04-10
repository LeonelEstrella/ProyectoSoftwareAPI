using Application.Interface;
using Application.Models;
using Azure.Core;
using Microsoft.AspNetCore.Mvc;

namespace RetailStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost]
        public async Task<IActionResult> PostProduct(CreateProductRequest request) 
        {
            var result = await _productService.CreateProduct(request);
            return new JsonResult(result) { StatusCode = 201} ;
        }

        [HttpGet("{productId}")]
        public async Task<IActionResult> GetProduct(Guid productId) 
        {
            var result = await _productService.GetProductById(productId);
            return new JsonResult(result);
        }
    }
}
