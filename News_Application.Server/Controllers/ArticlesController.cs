using Microsoft.AspNetCore.Mvc;
using Nest;
using News.DTOs;
using News.Models;
using News.Repositories;
using News.Services;

namespace News.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {

        public ArticlesController(IArticleService service)
        {
            Service = service;
        }

        public IArticleService Service { get; }

        [HttpPost("AddArticle")]
        public async Task<IActionResult> AddArticle([FromForm]AddArticelDto dto)
        {
            var res = await Service.AddArticleAsync(dto);
            return Ok(res);
        }


        [HttpPut("UpdateArticle")]
       public async Task<IActionResult> UpdateArticle([FromForm] UpdateArticelDto article)
        {
            var res = await Service.UpdateArticleAsync(article);
            return Ok(res);
        }

        [HttpGet("GetAllArticles")]
       public async Task<IActionResult> GetAllArticles()
        {
            var res = await Service.GetAllArticles();
            return Ok(res);
        }

        [HttpGet("GetArticles")]
        public async Task<IActionResult> GetArticles([FromQuery] int page = 1, [FromQuery] int pagesize=5)
        {
            var res = await Service.GetAllArticles();
            var arts = res.Skip((page-1)*pagesize).Take(pagesize).ToList();
            return Ok(arts);
        }

        [HttpDelete("DeleteArticle")]
       public async Task<IActionResult> DeleteArticle(int id)
        {
            var res = await Service.DeleteArticleAsync(id);
            return Ok(res);
        }

        [HttpGet("GetLastArticles")]
        public async Task<IActionResult> GetLastArticles()
        {
            var res = await Service.GetLastArticles();

            return Ok(res);
        }

      

        [HttpGet("GetArticleByCategoryid")]
        public async Task<IActionResult> GetArticleByCategoryid(int id)
        {
            var res = await Service.GetArticleByCategoryid(id);
            return Ok(res);
        }

        [HttpGet("GetArticleById")]
        public async Task<IActionResult> GetArticleById(int id)
        {
            var res = await Service.GetArticleById(id);
            return Ok(res);
        }

        [HttpPost("UploadFiles")]
        public async Task<IActionResult> UploadFiles([FromForm]IFormFile file)
        {          
            var res = await Service.UploadFiles(file);
            return Ok(new {res});
        }

        [HttpGet("SearchArticle")]
        public async Task<IActionResult> SearchArticle(string key="")
        {
            var res = await Service.Search(key);
            return Ok(res);
        }
    }
}
