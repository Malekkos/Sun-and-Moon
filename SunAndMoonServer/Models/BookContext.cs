using Microsoft.EntityFrameworkCore;

namespace Book.Models;

public class BookContext
{
  public BookContext(DbContextOptions<BookContext> options)
    : base(options)
    {
    }

    public DbSet<Book> Books { get; set; } = null!;
}