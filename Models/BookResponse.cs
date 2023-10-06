namespace BookProject.Models
{
    public record BookResponse
    {
        public long Isbn { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
