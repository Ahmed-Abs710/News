using MediatR;
using News.CQRS.Queries.Request;
using News.Models;
using News.Repositories;

namespace News.CQRS.Queries.Hnadler
{
    public class GetAllUserHandler : IRequestHandler<GetAllUserQuery, IEnumerable<User>>
    {
        public GetAllUserHandler(IUserRepository user)
        {
            User = user;
        }

        public IUserRepository User { get; }

        public async Task<IEnumerable<User>> Handle(GetAllUserQuery request, CancellationToken cancellationToken)
        {
            return await User.GetAllAsync();
        }
    }
}
