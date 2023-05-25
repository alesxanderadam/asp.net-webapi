using Altic_Shaw_Net6_Api.Entities;
using Altic_Shaw_Net6_Api.Models;
using Altic_Shaw_Net6_Api.Repositories.Categories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Altic_Shaw_Net6_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepo;
        public CategoriesController(ICategoryRepository repo)
        {
            _categoryRepo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> getAll()
        {
            try
            {
                return Ok(await _categoryRepo.getAllCategoriesAsync());
            }catch(Exception err)
            {
                return Problem(err.Message);
            }
        }

        [HttpGet("{categoryId}")]
        public async Task<IActionResult> getCategoryById(int categoryId)
        {
            try
            {
                var check = await _categoryRepo.getCategoryAsync(categoryId);
                return check == null ? NotFound() : Ok(check);
            }catch(Exception err)
            {
                return Problem(err.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> updateCategory(int categoryId, [FromBody] CategoryModel category)
        {
            try
            {
                if(categoryId is < 0 or 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(categoryId));
                }
                var check = await _categoryRepo.updateCategoryAsync(categoryId,category);
                if(check != 1)
                {
                    return BadRequest(HttpStatusCode.BadRequest);
                }
                if(categoryId != category.Id)
                {
                    return NotFound("Mã danh mục không trùng khớp");
                }
                return Ok("Sửa thành công");
            }
            catch (Exception err)
            {
                return Problem(err.Message);
            }
        }

    }
}
