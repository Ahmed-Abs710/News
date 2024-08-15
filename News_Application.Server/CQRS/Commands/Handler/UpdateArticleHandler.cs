using MediatR;
using News.CQRS.Commands.Request;
using News.Models;
using News.Repositories;

namespace News.CQRS.Commands.Handler
{
    public class UpdateArticleHandler : IRequestHandler<UpdateArticleCommand, Article>
    {
        public UpdateArticleHandler(IArticleRepository article)
        {
            Article = article;
        }

        public IArticleRepository Article { get; }

        public async Task<Article> Handle(UpdateArticleCommand request, CancellationToken cancellationToken)
        {
            return await Article.UpdateArticleAsync(request.Dto);
        }
    }
}
