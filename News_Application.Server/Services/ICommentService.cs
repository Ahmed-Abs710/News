using News.DTOs;
using News.Models;

namespace News.Services
{
    public interface ICommentService
    {
        Task<Comment> AddCommentAsync(CommentDto comment);

        Task<Comment> UpdateCommentAsync(UpdateCommentDto comment);

        Task<bool> DeleteCommentAsync(int id);

        Task<IEnumerable<Comment>> GetAllCommentByArticleIdAsync(int articleId);

    }
}
