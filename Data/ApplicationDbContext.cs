using Microsoft.EntityFrameworkCore;
using BookProject.Entities;
using BookProject.Models;

namespace BookProject.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}

		public DbSet<Author> Authors { get; set; }
		public DbSet<Book> Books { get; set; }
	
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Author>()
				.HasData(
				new Author()
				{
					Id = 1,
					FirstName = "Greg",
					LastName = "Martin",
				},
				new Author()
				{
					Id = 2,
					FirstName = "John",
					LastName = "Doe"
				},
				new Author()
				{
					Id = 3,
					FirstName = "Nima",
					LastName = "Hariku"
				});
			modelBuilder.Entity<Book>()
				.HasData(
				new Book()
				{
					ISBN = 000_000_000_001,
					Title = "On the way",
					Genre = "Science Fiction",
					Description = "Lorem ipsum",
					AuthorId = 1
				},
				new Book()
				{
					ISBN = 000_000_000_002,
					Title = "On the way2",
					Genre = "Science Fiction",
					Description = "Lorem ipsum",
					AuthorId = 1
				},
				new Book()
				{
					ISBN = 000_000_000_003,
					Title = "On the way3",
					Genre = "Science Fiction",
					Description = "Lorem ipsum",
					AuthorId = 2
				}
				);
		}
	}
}
