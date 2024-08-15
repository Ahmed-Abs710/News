using System.ComponentModel.DataAnnotations;

namespace News.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        public string? Content {  get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public string? Username { get; set; }

        public int ArticleId {  get; set; }

        public User? user { get; set; }

        public Article? Article { get; set; }

        
    }
}
