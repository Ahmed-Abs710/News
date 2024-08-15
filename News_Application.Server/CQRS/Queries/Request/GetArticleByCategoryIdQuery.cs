using MediatR;
using News.Models;

namespace News.CQRS.Queries.Request
{
    public record GetArticleByCategoryIdQuery(int id) : IRequest<IEnumerable<Article>>;
  
}
