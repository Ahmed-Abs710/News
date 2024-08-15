using MediatR;
using News.Models;

namespace News.CQRS.Queries.Request
{
    public record GetLastArticlesQuery : IRequest<IEnumerable<Article>>;
   
}
