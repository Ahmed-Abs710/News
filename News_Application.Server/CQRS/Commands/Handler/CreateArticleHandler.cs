using MediatR;
using News.CQRS.Commands.Request;
using News.DTOs;
using News.Models;
using News.Repositories;

namespace News.CQRS.Commands.Handler
{
    public class CreateArticleHandler : IRequestHandler<CreateArticleCommand, AddArticelDto>
    {
        public CreateArticleHandler(IArticleRepository article)
        {
            Article = article;
        }

        public IArticleRepository Article { get; }

        public async Task<AddArticelDto> Handle(CreateArticleCommand request, CancellationToken cancellationToken)
        {
            return await Article.AddArticleAsync(request.Dto);
        }

    
    }
}
