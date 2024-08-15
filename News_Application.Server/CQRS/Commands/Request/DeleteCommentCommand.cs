using MediatR;

namespace News.CQRS.Commands.Request
{
    public record DeleteCommentCommand(int id) : IRequest<bool>;
   
}
