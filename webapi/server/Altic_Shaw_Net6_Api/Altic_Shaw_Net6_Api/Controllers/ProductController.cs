using Altic_Shaw_Net6_Api.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Altic_Shaw_Net6_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepo;

        public ProductController(IProductRepository repo) {
            _productRepo = repo;
        }
        [HttpGet]
        public async Task<IActionResult> getAllProduct()
        {
            try {

                return Ok(await _productRepo.getAllProductAsync());
            }
            catch (Exception ex) { 
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> getProductById(int id)
        {
            try {
                var product = await _productRepo.getProductByIdAsync(id);

                if (id == 0)
                {       
                     return BadRequest();
                }
                return Ok();
            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

                   
    }
}
