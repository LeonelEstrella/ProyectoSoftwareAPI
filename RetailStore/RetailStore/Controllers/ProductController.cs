using Application.Interface.ProductInterfaces;
using Application.Models;
using Application.Util;
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
        public async Task<IActionResult> PostProduct(ProductRequest request) 
        {
            try
            {
               var result = await _productService.CreateProduct(request);
               return new JsonResult(result) { StatusCode = 201 };
            }
            catch (BadRequestException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
            catch (ConflictException ex)
            {
                return Conflict(new { message = ex.Message });
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(Guid id) 
        {
            try
            {
                var result = await _productService.GetProductById(id);
                return new JsonResult(result);
            }
            catch (NotFoundException ex)
            {
                return NotFound(new { message = ex.Message });
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct(Guid id, ProductRequest request)
        {
            try
            {
                var result = await _productService.UpdateProduct(id, request);
                return new JsonResult(result);
            }
            catch (NotFoundException ex)
            {
                return NotFound(new { message = ex.Message });
            }
            catch (BadRequestException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
            catch (ConflictException ex)
            {
                return Conflict(new { message = ex.Message });
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductById(Guid id)
        {
            try
            {
                var result = await _productService.DeleteProductById(id);
                return new JsonResult(result);
            }
            catch (NotFoundException ex)
            {
                return NotFound(new { message = ex.Message });
            }
            catch (ConflictException ex)
            {
                return Conflict(new { message = ex.Message });
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetProductList(
            [FromQuery] List<int> categories = null,
            [FromQuery] string name = "",
            [FromQuery] int limit = 0,
            [FromQuery] int offset = 0)
            
        {
            var result = await _productService.GetProductList(categories, name, offset, limit);
            return new JsonResult(result);
        }
    }
}
