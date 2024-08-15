using MediatR;
using News.Models;

namespace News.CQRS.Queries.Request
{
    public record GetAllArticlesQuery : IRequest<IEnumerable<Article>>;
  
}
