using System.ComponentModel.DataAnnotations;

namespace BookProject.Entities
{
	public class Book
	{
		[Key]
		public long ISBN { get; set; }
		public string Title { get; set; } = string.Empty;
		public string Genre { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
		public int AuthorId {  get; set; }
	}
}
