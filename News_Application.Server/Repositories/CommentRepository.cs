using Microsoft.EntityFrameworkCore;
using News.Data;
using News.DTOs;
using News.Models;

namespace News.Repositories
{
    public class CommentRepository : ICommentRepository
    {
        public CommentRepository(AppDbContext context)
        {
            Context = context;
        }

        public AppDbContext Context { get; }

        public async Task<Comment> AddCommentAsync(CommentDto comment)
        {
            var user = await Context.users.FindAsync(comment.UserId);
            if (user != null)
            {
                var com = new Comment
                {
                    ArticleId = comment.ArticleId,
                    Content = comment.Content,
                    Username = user.Username
                };
                await Context.comments.AddAsync(com);
                await Context.SaveChangesAsync();
                return com;
            }
            return null;
        }

        public async Task<bool> DeleteCommentAsync(int id)
        {
            var res = await Context.comments.FindAsync(id);
            if (res != null)
            {
                Context.comments.Remove(res);
                await Context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<IEnumerable<Comment>> GetAllCommentByArticleIdAsync(int articleId)
        {
            return await Context.comments.Where(com => com.ArticleId == articleId).ToListAsync();
        }

        public async Task<Comment> UpdateCommentAsync(UpdateCommentDto comment)
        {
            var res = await Context.comments.FindAsync(comment.Id);
            if (res != null)
            {
                res.Content = comment.Content;
                Context.comments.Update(res);
                await Context.SaveChangesAsync();
                return res;
            }
            else
            {
                return null;
            }
        }
    }
}
