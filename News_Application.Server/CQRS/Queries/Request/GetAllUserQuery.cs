using MediatR;
using News.Models;

namespace News.CQRS.Queries.Request
{
    public record GetAllUserQuery : IRequest<IEnumerable<User>>;
   
}
