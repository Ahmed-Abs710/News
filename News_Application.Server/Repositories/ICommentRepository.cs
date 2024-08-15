using News.DTOs;
using News.Models;
using System.Collections;

namespace News.Repositories
{
    public interface ICommentRepository
    {
        Task<Comment> AddCommentAsync(CommentDto comment);

        Task<Comment> UpdateCommentAsync(UpdateCommentDto comment);

        Task<bool> DeleteCommentAsync(int id);

        Task<IEnumerable<Comment>>GetAllCommentByArticleIdAsync(int articleId);

    }
}
