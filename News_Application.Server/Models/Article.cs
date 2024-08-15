using News_Application.Server.Models;
using System.ComponentModel.DataAnnotations;

namespace News.Models
{
    public class Article
    {
        [Key]
        public int id { get; set; }

        public string? Title {  get; set; }

        public string? Content {  get; set; }

        public string? PicPath { get; set; }

        public DateTime PublishDate {  get; set; } = DateTime.Now;

        public string? Author {  get; set; }

        public int CategoryId {  get; set; }

        public ICollection<Comment>? comments { get; set; }

        

    }
}
