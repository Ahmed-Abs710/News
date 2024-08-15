using MediatR;

namespace News.CQRS.Commands.Request
{
    public record DeleteArticleCommand(int id) : IRequest<bool>;
   
}
