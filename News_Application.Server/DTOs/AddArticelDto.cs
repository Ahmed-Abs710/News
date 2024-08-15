namespace News.DTOs
{
    public class AddArticelDto
    {
        public string? Title { get; set; }

        public string? Content { get; set; }

        public int Userid { get; set; }

        public int CategoryId { get; set; }

        public IFormFile? Pic { get; set; }

    }
}
