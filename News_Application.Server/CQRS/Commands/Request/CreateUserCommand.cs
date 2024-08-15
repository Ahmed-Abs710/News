using MediatR;
using News.DTOs;

namespace News.CQRS.Commands.Request
{
    public record CreateUserCommand(CreateUserDto Dto) : IRequest<UserDto>;
   
}
