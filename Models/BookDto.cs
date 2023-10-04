namespace BookProject.Models
{
    public class BookDto
    {
        public long  ISBN { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

    }
}
