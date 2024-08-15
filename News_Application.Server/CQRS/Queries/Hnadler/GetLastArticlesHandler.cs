using MediatR;
using News.CQRS.Queries.Request;
using News.Models;
using News.Repositories;

namespace News.CQRS.Queries.Hnadler
{
    public class GetLastArticlesHandler : IRequestHandler<GetLastArticlesQuery, IEnumerable<Article>>
    {
        public GetLastArticlesHandler(IArticleRepository article)
        {
            Article = article;
        }

        public IArticleRepository Article { get; }

        public async Task<IEnumerable<Article>> Handle(GetLastArticlesQuery request, CancellationToken cancellationToken)
        {
            return await Article.GetLastArticles();
        }
    }
}
