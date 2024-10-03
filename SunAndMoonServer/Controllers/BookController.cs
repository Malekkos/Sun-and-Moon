using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Book.Models;

namespace SunAndMoonServer.Controllers
{
    [Route("api/Book")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly BookContext _context;

        public BookController(BookContext context)
        {
            _context = context;
        }

        // GET: api/Book
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookInfo>>> GetBooks()
        {
            return await _context.Books.ToListAsync();
        }

        // GET: api/Book/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BookInfo>> GetBookInfo(long id)
        {
            var bookInfo = await _context.Books.FindAsync(id);

            if (bookInfo == null)
            {
                return NotFound();
            }

            return bookInfo;
        }

        // PUT: api/Book/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBookInfo(long id, BookInfo bookInfo)
        {
            if (id != bookInfo.Id)
            {
                return BadRequest();
            }

            _context.Entry(bookInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookInfoExists(id))
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

        // POST: api/Book
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<BookInfo>> PostBookInfo(BookInfo bookInfo)
        {
            _context.Books.Add(bookInfo);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetBookInfo), new { id = bookInfo.Id }, bookInfo);
        }

        // DELETE: api/Book/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBookInfo(long id)
        {
            var bookInfo = await _context.Books.FindAsync(id);
            if (bookInfo == null)
            {
                return NotFound();
            }

            _context.Books.Remove(bookInfo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BookInfoExists(long id)
        {
            return _context.Books.Any(e => e.Id == id);
        }
    }
}
