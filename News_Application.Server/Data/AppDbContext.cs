using Microsoft.EntityFrameworkCore;
using News.Models;

namespace News.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<User> users { get; set; }

        public DbSet<Comment> comments { get; set; }

        public DbSet<Category> categories { get; set; }

        public DbSet<Article> articles { get; set; }

    }
}
