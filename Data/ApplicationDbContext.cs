using Microsoft.EntityFrameworkCore;
using BookProject.Entities;

namespace BookProject.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { 
		
		}

		public DbSet<Author> Authors { get; set; }
		public DbSet<Book> Books { get; set; }

	}
}
