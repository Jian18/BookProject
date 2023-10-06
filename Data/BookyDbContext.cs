using Microsoft.EntityFrameworkCore;
using BookProject.Entities;
using BookProject.Models;

namespace BookProject.Data
{
	public class BookyDbContext : DbContext
	{
		public BookyDbContext(DbContextOptions<BookyDbContext> options) : base(options)
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
						AuthorId = 1,
						FirstName = "Greg",
						LastName = "Martin",
					},
					new Author()
					{
						AuthorId = 2,
						FirstName = "John",
						LastName = "Doe"
					},
					new Author()
					{
						AuthorId = 3,
						FirstName = "Nima",
						LastName = "Hariku"
					}
				);
			modelBuilder.Entity<Book>()
				.HasData(
					new Book()
					{
						BookId = 1,
						ISBN =1111111111,
						Title = "On the way",
						Genre = "Science Fiction",
						Description = "Lorem ipsum",
						AuthorId = 1
					},
					new Book()
					{
						BookId= 2,
						ISBN =2222222222,
						Title = "On the way2",
						Genre = "Science Fiction",
						Description = "Lorem ipsum",
						AuthorId = 1
					},
					new Book()
					{
						BookId = 3,
						ISBN =3333333333,
						Title = "On the way3",
						Genre = "Science Fiction",
						Description = "Lorem ipsum",
						AuthorId = 2
					}
				);
		}
	}
}
