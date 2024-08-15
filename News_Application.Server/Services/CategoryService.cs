using MediatR;
using News.CQRS.Commands.Request;
using News.Models;
using News_Application.Server.CQRS.Queries.Hnadler;
using News_Application.Server.CQRS.Queries.Request;

namespace News.Services
{
    public class CategoryService : ICategoryService
    {
        public CategoryService(IMediator mediator)
        {
            Mediator = mediator;
        }

        public IMediator Mediator { get; }

        public async Task<Category> AddCategory(string Name)
        {
            return await Mediator.Send(new CreateCategoryCommand(Name));
        }

        public async Task<IEnumerable<Category>> GetAllCategories()
        {
            return await Mediator.Send(new GetAllCategoriesQuery());
        }
    }
}
