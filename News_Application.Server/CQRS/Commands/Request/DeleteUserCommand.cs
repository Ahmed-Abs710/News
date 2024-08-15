using MediatR;

namespace News.CQRS.Commands.Request
{
    public record DeleteUserCommand(int id) : IRequest<bool>;
  
}
