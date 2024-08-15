using Microsoft.AspNetCore.Mvc;
using News.Models;
using News.Services;

namespace News.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        public CategoriesController(ICategoryService service)
        {
            Service = service;
        }

        public ICategoryService Service { get; }

        [HttpPost("AddCategory")]
        public async Task<IActionResult> AddCategory(string Name)
        {
            var res = await Service.AddCategory(Name);
            return Ok(res);
        }

        [HttpGet("GetAllCategories")]
        public async Task<IActionResult> GetAllCategories()
        {
            var res = await Service.GetAllCategories();
            return Ok(res);
        }
    }
}
