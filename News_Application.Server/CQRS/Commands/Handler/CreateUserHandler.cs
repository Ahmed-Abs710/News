using MediatR;
using News.CQRS.Commands.Request;
using News.DTOs;
using News.Repositories;

namespace News.CQRS.Commands.Handler
{
    public class CreateUserHandler : IRequestHandler<CreateUserCommand, UserDto>
    {
        public CreateUserHandler(IUserRepository repository)
        {
            Repository = repository;
        }

        public IUserRepository Repository { get; }

        public async Task<UserDto> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            return await Repository.AddAsync(request.Dto);
        }
    }
}
