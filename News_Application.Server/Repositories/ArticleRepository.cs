using Microsoft.EntityFrameworkCore;
using Nest;
using News.Data;
using News.DTOs;
using News.Models;
using News.Services;
using System.Net.WebSockets;

namespace News.Repositories
{
    public class ArticleRepository : IArticleRepository
    {
        public ArticleRepository(AppDbContext context, IElasticClient client1, IArticleService article)
        {
            Context = context;
            Client1 = client1;
            Article = article;
        }

        public AppDbContext Context { get; }
        public IElasticClient Client1 { get; }
        public IArticleService Article { get; }

        public async Task<AddArticelDto> AddArticleAsync(AddArticelDto article)
        {
            var user = await Context.users.FindAsync(article.Userid);
            var picpath = await Article.UploadFiles(article.Pic);
               
            if (user != null)
            {
                var art = new Article {
                    Title = article.Title,
                    Content = article.Content,
                    Author = user.Username,
                    CategoryId = article.CategoryId,
                    PicPath = picpath
                };
                await Context.articles.AddAsync(art);
                await Context.SaveChangesAsync();
                return article;
            }
            else
            {
                return null;
            }
           
        }

        public async Task<bool> DeleteArticleAsync(int id)
        {
            var res = await Context.articles.FindAsync(id);
            if (res != null)
            {
                Context.articles.Remove(res);
                await Context.SaveChangesAsync();
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<IEnumerable<Article>> GetAllArticles()
        {
            return await Context.articles.ToListAsync();
        }

        public async Task<IEnumerable<Article>> GetArticleByCategoryid(int id)
        {
            return await Context.articles.Where(ar =>ar.CategoryId == id).ToListAsync();
        }

        public async Task<Article> GetArticleById(int id)
        {
           
                var res =  await Context.articles.FindAsync(id);
            if (res != null)
            {
                return res;
            }
            return null;
        }

        public async Task<IEnumerable<Article>> GetLastArticles()
        {
            var cats = await Context.categories.ToListAsync();
            var news = new List<Article>();
            foreach (var c in cats)
            {
                var res = await Context.articles.Where(cid => cid.CategoryId == c.Id).OrderByDescending(c => c.id).FirstOrDefaultAsync();
                if (res != null)
                {
                    news.Add(res);
                }
            }
            return news;
        }

     

        public async Task<IEnumerable<Article>> SearchArticlesAsync(string Keyword="")
        {
            //var list = await GetAllArticles();
            //foreach (var item in list)
            //{
            //  await Client1.IndexDocumentAsync(item);
            //}
            //var SearchResponse = await Client1.SearchAsync<Article>(s => 
            //s.Query(q=>q.MultiMatch(m=>m.Fields(f=>f.Field(a=>a.Title).Field(a=>a.Content)).Query(Keyword))));
            //return SearchResponse.Documents;
            if(string.IsNullOrEmpty(Keyword)) {return await Context.articles.ToListAsync();}

            return await Context.articles.Where(t => t.Title.Contains(Keyword) || t.Content.Contains(Keyword)).ToListAsync();
        }

        public async Task<Article> UpdateArticleAsync(UpdateArticelDto article)
        {
            var user = await Context.users.FindAsync(article.Userid);
            var art = await Context.articles.FindAsync(article.id);
            if (user != null && art != null)
            {
                art.Author = user.Username;
                art.CategoryId = article.CategoryId;
                art.Title = article.Title;
                art.Content = article.Content;
                Context.articles.Update(art);
                await Context.SaveChangesAsync();
                return art;
            }
            else
            {
                return null;
            }
        }
    }
}
