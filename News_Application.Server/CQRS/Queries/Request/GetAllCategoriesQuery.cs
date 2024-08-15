using MediatR;
using News.Models;

namespace News_Application.Server.CQRS.Queries.Request
{
   public record GetAllCategoriesQuery:IRequest<IEnumerable<Category>>;
    
}
