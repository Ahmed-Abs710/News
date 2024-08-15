using MediatR;
using News.Models;

namespace News.CQRS.Queries.Request
{
    public record GetCommentsByArticleIdQuery(int id) : IRequest<IEnumerable<Comment>>;
  
}
