using MediatR;
using News.CQRS.Commands.Request;
using News.CQRS.Queries.Request;
using News.DTOs;
using News.Models;

namespace News.Services
{
    public class CommentService : ICommentService
    {
        public CommentService(IMediator mediator)
        {
            Mediator = mediator;
        }

        public IMediator Mediator { get; }

        public async Task<Comment> AddCommentAsync(CommentDto comment)
        {
            return await Mediator.Send(new CreateCommentCommand(comment));
        }

        public async Task<bool> DeleteCommentAsync(int id)
        {
            return await Mediator.Send(new DeleteCommentCommand(id));
        }

        public async Task<IEnumerable<Comment>> GetAllCommentByArticleIdAsync(int articleId)
        {
            return await Mediator.Send(new GetCommentsByArticleIdQuery(articleId));
        }

        public async Task<Comment> UpdateCommentAsync(UpdateCommentDto comment)
        {
            return await Mediator.Send(new UpdateCommentCommand(comment));
        }
    }
}
