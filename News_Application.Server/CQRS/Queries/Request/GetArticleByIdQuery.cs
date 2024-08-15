using MediatR;
using News.Models;

namespace News.CQRS.Queries.Request
{
    public record GetArticleByIdQuery(int id) : IRequest<Article>;
   
}
