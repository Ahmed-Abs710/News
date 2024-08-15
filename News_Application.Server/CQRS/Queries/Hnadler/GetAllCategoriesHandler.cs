using MediatR;
using News.Models;
using News.Repositories;
using News.Services;
using News_Application.Server.CQRS.Queries.Request;

namespace News_Application.Server.CQRS.Queries.Hnadler
{
    public class GetAllCategoriesHandler : IRequestHandler<GetAllCategoriesQuery, IEnumerable<Category>>
    {
        public GetAllCategoriesHandler(ICategoryRepository service)
        {
            Service = service;
        }

        public ICategoryRepository Service { get; }

        public async Task<IEnumerable<Category>> Handle(GetAllCategoriesQuery request, CancellationToken cancellationToken)
        {
            return await Service.GetAllCategoryies();
        }
    }
}
