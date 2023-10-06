using System.ComponentModel.DataAnnotations.Schema;

namespace BookProject.Entities
{
	public class Book
	{
		public int BookId { get; set; }
		public long Isbn { get; set; }
		public string Title { get; set; } = string.Empty;
		public string Genre { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
		public int AuthorId {  get; set; }

        // navigation property
        [ForeignKey("AuthorId")]
        public Author Author { get; set; } = null!;
	}
}
