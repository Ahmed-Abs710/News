using MediatR;
using News.Models;

namespace News.CQRS.Commands.Request
{
    public record CreateCategoryCommand(string name) : IRequest<Category>;

}
