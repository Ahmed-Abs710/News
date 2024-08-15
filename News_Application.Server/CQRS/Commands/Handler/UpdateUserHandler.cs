using MediatR;
using News.CQRS.Commands.Request;
using News.DTOs;
using News.Repositories;

namespace News.CQRS.Commands.Handler
{
    public class UpdateUserHandler : IRequestHandler<UpdateUserCommand, UserDto>
    {
        public UpdateUserHandler(IUserRepository user)
        {
            User = user;
        }

        public IUserRepository User { get; }

        public async Task<UserDto> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            return await User.UpdateAsync(request.Dto);
        }
    }
}
