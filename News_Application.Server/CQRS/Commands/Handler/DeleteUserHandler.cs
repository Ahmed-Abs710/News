using MediatR;
using News.CQRS.Commands.Request;
using News.Repositories;

namespace News.CQRS.Commands.Handler
{
    public class DeleteUserHandler : IRequestHandler<DeleteUserCommand, bool>
    {
        public DeleteUserHandler(IUserRepository user)
        {
            User = user;
        }

        public IUserRepository User { get; }

        public async Task<bool> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            return await User.DeleteAsync(request.id);
        }
    }
}
