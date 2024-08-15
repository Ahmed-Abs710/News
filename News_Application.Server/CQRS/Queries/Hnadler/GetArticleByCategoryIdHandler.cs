using MediatR;
using News.CQRS.Queries.Request;
using News.Models;
using News.Repositories;

namespace News.CQRS.Queries.Hnadler
{
    public class GetArticleByCategoryIdHandler : IRequestHandler<GetArticleByCategoryIdQuery, IEnumerable<Article>>
    {
        public GetArticleByCategoryIdHandler(IArticleRepository article)
        {
            Article = article;
        }

        public IArticleRepository Article { get; }

        public async Task<IEnumerable<Article>> Handle(GetArticleByCategoryIdQuery request, CancellationToken cancellationToken)
        {
            return await Article.GetArticleByCategoryid(request.id);
        }
    }
}
