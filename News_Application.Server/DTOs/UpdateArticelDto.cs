namespace News.DTOs
{
    public class UpdateArticelDto
    {
        public int id { get; set; }
        public string? Title { get; set; }

        public string? Content { get; set; }

        public int Userid { get; set; }

        public int CategoryId { get; set; }
    }
}
