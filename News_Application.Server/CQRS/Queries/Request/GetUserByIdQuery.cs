using MediatR;
using News.DTOs;

namespace News.CQRS.Queries.Request
{
    public record GetUserByIdQuery(int id) : IRequest<UserDto>;
   
}
