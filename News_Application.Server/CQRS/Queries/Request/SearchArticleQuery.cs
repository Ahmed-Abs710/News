using MediatR;
using News.Models;

namespace News_Application.Server.CQRS.Queries.Request
{
    public record SearchArticleQuery(string key):IRequest<IEnumerable<Article>>;
    
}
