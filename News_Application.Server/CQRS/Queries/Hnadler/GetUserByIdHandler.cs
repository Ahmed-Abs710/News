using MediatR;
using News.CQRS.Queries.Request;
using News.DTOs;
using News.Repositories;

namespace News.CQRS.Queries.Hnadler
{
    public class GetUserByIdHandler : IRequestHandler<GetUserByIdQuery, UserDto>
    {
        public GetUserByIdHandler(IUserRepository user)
        {
            User = user;
        }

        public IUserRepository User { get; }

        public async Task<UserDto> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            return await User.GetUsersByIdAsync(request.id);
        }
    }
}
