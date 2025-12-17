using Application.Service;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var product = await _productService.GetByIdAsync(id);

            if (product == null) 
            {
                return NotFound();
            }

            return Ok(product);
        }
    }
}
