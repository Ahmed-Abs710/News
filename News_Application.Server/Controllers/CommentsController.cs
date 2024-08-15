using Microsoft.AspNetCore.Mvc;
using News.DTOs;
using News.Models;
using News.Services;

namespace News.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        public CommentsController(ICommentService service)
        {
            Service = service;
        }

        public ICommentService Service { get; }

        [HttpPost("AddComment")]
       public async Task<Comment> AddComment(CommentDto comment)
        {
            return await Service.AddCommentAsync(comment);
        }

        [HttpPut("UpdateComment")]
       public async Task<Comment> UpdateComment(UpdateCommentDto comment)
        {
            return await Service.UpdateCommentAsync(comment);
        }

        [HttpDelete("DeleteComment")]
       public async Task<bool> DeleteComment(int id)
        {
            return await Service.DeleteCommentAsync(id);
        }

        [HttpGet("GetAllCommentByArticleId")]
       public async Task<IEnumerable<Comment>> GetAllCommentByArticleId(int articleId)
        {
            return await Service.GetAllCommentByArticleIdAsync(articleId);
        }

    }
}
