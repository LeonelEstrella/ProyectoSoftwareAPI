using Application.Interface.SaleInterface;
using Application.Models;
using Application.Util;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RetailStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaleController : ControllerBase
    {
        private readonly ISaleService _saleService;

        public SaleController(ISaleService saleService)
        {
            _saleService = saleService;
        }

        [HttpPost]
        public async Task<IActionResult> PostSale(CreateSaleRequest request)
        {
            try
            {
                var result = await _saleService.CreateSale(request);
                return new JsonResult(result) { StatusCode = 201 };
            }
            catch (BadRequestException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSale(int id)
        {
            try
            {
                var result = await _saleService.GetSaleById(id);
                return new JsonResult(result);
            }
            catch (NotFoundException ex)
            {
                return NotFound(new { message = ex.Message });
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetSalesList([FromQuery] DateTime? from = null, [FromQuery] DateTime? to = null)
        {
            try
            {
                var result = _saleService.GetSalesList(from, to);
                return new JsonResult(result);
            }
            catch (BadRequestException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
    }
}
