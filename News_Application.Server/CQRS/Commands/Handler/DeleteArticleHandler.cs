using MediatR;
using News.CQRS.Commands.Request;
using News.Repositories;

namespace News.CQRS.Commands.Handler
{
    public class DeleteArticleHandler : IRequestHandler<DeleteArticleCommand, bool>
    {
        public DeleteArticleHandler(IArticleRepository article)
        {
            Article = article;
        }

        public IArticleRepository Article { get; }

        public async Task<bool> Handle(DeleteArticleCommand request, CancellationToken cancellationToken)
        {
            return await Article.DeleteArticleAsync(request.id);
        }
    }
}
