using MediatR;
using News.CQRS.Queries.Request;
using News.Models;
using News.Repositories;

namespace News.CQRS.Queries.Hnadler
{
    public class GetCommentsByArticleIdHandler : IRequestHandler<GetCommentsByArticleIdQuery, IEnumerable<Comment>>
    {
        public GetCommentsByArticleIdHandler(ICommentRepository comment)
        {
            Comment = comment;
        }

        public ICommentRepository Comment { get; }

        public async Task<IEnumerable<Comment>> Handle(GetCommentsByArticleIdQuery request, CancellationToken cancellationToken)
        {
            return await Comment.GetAllCommentByArticleIdAsync(request.id);
        }
    }
}
