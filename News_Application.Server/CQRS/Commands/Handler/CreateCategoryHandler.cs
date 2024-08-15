using MediatR;
using News.CQRS.Commands.Request;
using News.Models;
using News.Repositories;

namespace News.CQRS.Commands.Handler
{
    public class CreateCategoryHandler : IRequestHandler<CreateCategoryCommand, Category>
    {
        public CreateCategoryHandler(ICategoryRepository category)
        {
            Category = category;
        }

        public ICategoryRepository Category { get; }

        public async Task<Category> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            return await Category.AddCategory(request.name);
        }
    }


}
