using MediatR;
using News.DTOs;

namespace News.CQRS.Commands.Request
{
    public record UpdateUserCommand(UpdateUserDto Dto) : IRequest<UserDto>;
   
}
