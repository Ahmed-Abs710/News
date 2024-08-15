using MediatR;
using News.Models;
using News.Repositories;
using News_Application.Server.CQRS.Queries.Request;

namespace News_Application.Server.CQRS.Queries.Hnadler
{
    public class SearchArticleHandler : IRequestHandler<SearchArticleQuery, IEnumerable<Article>>
    {
        public SearchArticleHandler(IArticleRepository article)
        {
            Article = article;
        }

        public IArticleRepository Article { get; }

        public async Task<IEnumerable<Article>> Handle(SearchArticleQuery request, CancellationToken cancellationToken)
        {
            return await Article.SearchArticlesAsync(request.key);
        }
    }
}
