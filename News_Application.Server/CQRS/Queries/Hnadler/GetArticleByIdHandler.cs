using MediatR;
using News.CQRS.Queries.Request;
using News.Models;
using News.Repositories;

namespace News.CQRS.Queries.Hnadler
{
    public class GetArticleByIdHandler : IRequestHandler<GetArticleByIdQuery, Article>
    {
        public GetArticleByIdHandler(IArticleRepository article)
        {
            Article = article;
        }

        public IArticleRepository Article { get; }

        public async Task<Article> Handle(GetArticleByIdQuery request, CancellationToken cancellationToken)
        {
            return await Article.GetArticleById(request.id);
        }
    }
}
