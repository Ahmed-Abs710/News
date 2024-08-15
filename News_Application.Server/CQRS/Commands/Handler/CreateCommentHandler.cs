using MediatR;
using News.CQRS.Commands.Request;
using News.Models;
using News.Repositories;

namespace News.CQRS.Commands.Handler
{
    public class CreateCommentHandler : IRequestHandler<CreateCommentCommand, Comment>
    {
        public CreateCommentHandler(ICommentRepository comment)
        {
            Comment = comment;
        }

        public ICommentRepository Comment { get; }

        public async Task<Comment> Handle(CreateCommentCommand request, CancellationToken cancellationToken)
        {
            return await Comment.AddCommentAsync(request.Dto);
        }
    }
}
