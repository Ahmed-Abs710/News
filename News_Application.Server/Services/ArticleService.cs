using MediatR;
using News.CQRS.Commands.Request;
using News.CQRS.Queries.Request;
using News.DTOs;
using News.Models;
using News_Application.Server.CQRS.Queries.Request;

namespace News.Services
{
    public class ArticleService : IArticleService
    {
        public ArticleService(IMediator mediator, IWebHostEnvironment webHost, IHttpContextAccessor accessor)
        {
            Mediator = mediator;
            WebHost = webHost;
            Accessor = accessor;
        }

        public IMediator Mediator { get; }
        public IWebHostEnvironment WebHost { get; }
        public IHttpContextAccessor Accessor { get; }

        public async Task<AddArticelDto> AddArticleAsync(AddArticelDto article)
        {
            return await Mediator.Send(new CreateArticleCommand(article));
        }

        public async Task<bool> DeleteArticleAsync(int id)
        {
            return await Mediator.Send(new DeleteArticleCommand(id));
        }

        public async Task<IEnumerable<Article>> GetAllArticles()
        {
           return await Mediator.Send(new GetAllArticlesQuery());
        }

        public async Task<IEnumerable<Article>> GetArticleByCategoryid(int id)
        {
            return await Mediator.Send(new GetArticleByCategoryIdQuery(id));
        }

        public async Task<Article> GetArticleById(int id)
        {
            return await Mediator.Send(new GetArticleByIdQuery(id));
        }

        public async Task<IEnumerable<Article>> GetLastArticles()
        {
            return await Mediator.Send(new GetLastArticlesQuery());
        }

        public async Task<Article> UpdateArticleAsync(UpdateArticelDto article)
        {
            return await Mediator.Send(new UpdateArticleCommand(article));
        }

        public async Task<string> UploadFiles(IFormFile file)
        {
            var filename = Guid.NewGuid() + "_" + file.FileName;
            var uploadpath = Path.Combine(WebHost.WebRootPath, "Uploads", filename);
            
            using (var stream = new FileStream(uploadpath,FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            return $"{Accessor.HttpContext.Request.Scheme}://{Accessor.HttpContext.Request.Host}/Uploads/{filename}";
        }

        public async Task<IEnumerable<Article>> Search(string key)
        {
            return await Mediator.Send(new SearchArticleQuery(key));
        }
    }
}
