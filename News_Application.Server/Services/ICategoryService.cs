using News.Models;

namespace News.Services
{
    public interface ICategoryService
    {
        Task<Category> AddCategory(string Name);

        Task<IEnumerable<Category>> GetAllCategories();
    }
}
