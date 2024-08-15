using News.DTOs;
using News.Models;

namespace News.Services
{
    public interface IArticleService
    {
        Task<AddArticelDto> AddArticleAsync(AddArticelDto article);

        Task<Article> UpdateArticleAsync(UpdateArticelDto article);

        Task<IEnumerable<Article>> GetAllArticles();

        Task<bool> DeleteArticleAsync(int id);

        Task<IEnumerable<Article>> GetLastArticles();

        Task<IEnumerable<Article>> GetArticleByCategoryid(int id);

        Task<Article> GetArticleById(int id);

        Task<string> UploadFiles(IFormFile file);

        Task<IEnumerable<Article>> Search(string key);

    }
}
