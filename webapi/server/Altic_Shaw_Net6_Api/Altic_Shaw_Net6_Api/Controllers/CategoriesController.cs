using Altic_Shaw_Net6_Api.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Altic_Shaw_Net6_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly AlaticShawContext _alaticShawContext;
        public CategoriesController(AlaticShawContext ctx)
        {
            _alaticShawContext = ctx;
        }

        [HttpGet]
        public IActionResult getAll()
        {
            return Ok(_alaticShawContext.Categories.ToList());
        }
    }
}
