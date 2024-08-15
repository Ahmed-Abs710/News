using News.Models;
using System.ComponentModel.DataAnnotations;

namespace News_Application.Server.Models
{
    public class NewsPics
    {
        [Key]
        public int Id { get; set; }


        public string? Path {  get; set; }

        public int ArticleId {  get; set; }

    }
}
