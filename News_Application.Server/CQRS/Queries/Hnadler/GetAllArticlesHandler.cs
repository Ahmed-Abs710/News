using MediatR;
using News.CQRS.Queries.Request;
using News.Models;
using News.Repositories;

namespace News.CQRS.Queries.Hnadler
{
    public class GetAllArticlesHandler : IRequestHandler<GetAllArticlesQuery, IEnumerable<Article>>
    {
        public GetAllArticlesHandler(IArticleRepository article)
        {
            Article = article;
        }

        public IArticleRepository Article { get; }

        public async Task<IEnumerable<Article>> Handle(GetAllArticlesQuery request, CancellationToken cancellationToken)
        {
            return await Article.GetAllArticles();
        }
    }
}
