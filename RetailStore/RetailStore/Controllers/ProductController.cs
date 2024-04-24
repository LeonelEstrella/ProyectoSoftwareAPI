using Application.Interface;
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
        public async Task<IActionResult> PostProduct(CreateProductRequest request) 
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

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetProduct(Guid Id) 
        {
            try
            {
                var result = await _productService.GetProductById(Id);
                return new JsonResult(result);
            }
            catch (NotFoundException ex)
            {
                return NotFound(new { message = ex.Message });
            }
        }

        [HttpPatch("{Id}")]
        public async Task<IActionResult> PatchProduct(Guid Id, CreateProductRequest request)
        {
            try
            {
                var result = await _productService.UpdateProduct(Id, request);
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

        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteProductById(Guid Id)
        {
            try
            {
                var result = await _productService.DeleteProductById(Id);
                return new JsonResult(result);
            }
            catch (NotFoundException ex)
            {
                return NotFound(new { message = ex.Message });
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetProductList(
            [FromQuery] List<int> categories = null,
            [FromQuery] string name = "",
            [FromQuery] int skip = 0,
            [FromQuery] int limit = 0)
        {
            try
            {
                var result = _productService.GetProductList(categories, name, skip, limit);
                return new JsonResult(result);
            }
            catch (NotFoundException ex)
            {
                return NotFound(new { message = ex.Message });
            }
        }
    }
}
