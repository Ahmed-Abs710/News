using MediatR;
using News.CQRS.Commands.Request;
using News.Models;
using News.Repositories;

namespace News.CQRS.Commands.Handler
{
    public class UpdateCommentHandler : IRequestHandler<UpdateCommentCommand, Comment>
    {
        public UpdateCommentHandler(ICommentRepository comment)
        {
            Comment = comment;
        }

        public ICommentRepository Comment { get; }

        public async Task<Comment> Handle(UpdateCommentCommand request, CancellationToken cancellationToken)
        {
            return await Comment.UpdateCommentAsync(request.Dto);
        }
    }
}
