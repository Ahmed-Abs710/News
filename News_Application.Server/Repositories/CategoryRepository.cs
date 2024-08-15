using Microsoft.EntityFrameworkCore;
using News.Data;
using News.Models;

namespace News.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        public CategoryRepository(AppDbContext context)
        {
            Context = context;
        }
        public AppDbContext Context { get; }

        public async Task<Category> AddCategory(string name)
        {
            var cat = new Category
            {
                Name = name
            };
            await Context.categories.AddAsync(cat);
            await Context.SaveChangesAsync();
            return cat;
        }

        public async Task<IEnumerable<Category>> GetAllCategoryies()
        {
           return await Context.categories.ToListAsync();
        }
    }
}
