using MediatR;
using News.CQRS.Commands.Request;
using News.Repositories;

namespace News.CQRS.Commands.Handler
{
    public class DeleteCommentHandler : IRequestHandler<DeleteCommentCommand, bool>
    {
        public DeleteCommentHandler(ICommentRepository comment)
        {
            Comment = comment;
        }

        public ICommentRepository Comment { get; }

        public async Task<bool> Handle(DeleteCommentCommand request, CancellationToken cancellationToken)
        {
            return await Comment.DeleteCommentAsync(request.id);
        }
    }
}
