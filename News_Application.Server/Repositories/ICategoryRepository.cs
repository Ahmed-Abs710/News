using News.Models;

namespace News.Repositories
{
    public interface ICategoryRepository
    {
        Task<Category> AddCategory(string Name);

        Task<IEnumerable<Category>> GetAllCategoryies();
    }
}
