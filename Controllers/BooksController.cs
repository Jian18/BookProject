using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookProject.Data;
using BookProject.Entities;
using BookProject.Models;

namespace BookProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly BookyDbContext _context;

        public BooksController(BookyDbContext context)
        {
            _context = context;
        }

        // GET: api/Books
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookResponse>>> GetBooks()
        {
            if (_context.Books == null)
            {
                return NotFound();
            }
            return Ok(await _context.Books
                .Select(b => new BookResponse
                {
                    Isbn = b.Isbn,
                    Title = b.Title,
                    Genre = b.Genre,
                    Description = b.Description
                })
                .ToListAsync());
        }

        // GET: api/Books/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BookResponse>> GetBook(int id)
        {
            if (_context.Books == null)
            {
                return NotFound();
            }
            var book = await _context.Books.FindAsync(id);

            if (book == null)
            {
                return NotFound();
            }

            return Ok(new BookResponse
            {
                Isbn = book.Isbn,
                Title = book.Title,
                Genre = book.Genre,
                Description = book.Description
            });
        }

        //GET: api/Test/
        [HttpGet("/Test")]
        public async Task<ActionResult<IEnumerable<BookAuthorResponse>>> GetTestBooks()
        {
            return Ok(await _context.Books
                .Select(b => new BookAuthorResponse
                {
                    Isbn = b.Isbn,
                    Title = b.Title,
                    Genre = b.Genre,
                    Description = b.Description,
                    FirstName = b.Author.FirstName,
                    LastName = b.Author.LastName,
                })                
                .ToListAsync());
        }

        // PUT: api/Books/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBook(int id, Book book)
        {
            if (id != book.Isbn)
            {
                return BadRequest();
            }

            _context.Entry(book).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Books
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Book>> PostBook(Book book)
        {
            if (_context.Books == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Books'  is null.");
            }
            // var newBook = new Book() { ISBN =0,Title=book.Title,Genre=book.Genre,Description=book.Description,AuthorId=book.AuthorId}; 
            _context.Books.Add(book);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBook", new { id = book.Isbn }, book);
        }

        // DELETE: api/Books/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            if (_context.Books == null)
            {
                return NotFound();
            }
            var book = await _context.Books.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }

            _context.Books.Remove(book);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BookExists(int id)
        {
            return (_context.Books?.Any(e => e.Isbn == id)).GetValueOrDefault();
        }
    }
}
