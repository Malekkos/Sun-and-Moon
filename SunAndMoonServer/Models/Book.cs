namespace Book.Models

public class BookInfo
{
  public long Id { get; set; }
  public string? BookName { get; set;}
  public int? ChapterCount {get; set;}
  //would be a foreign key or something
  // If null, we can equate that to being 0 chapters
  public bool Finished {get; set;}
  // public int Rating { get; set;}
  // public int Views { get; set;}
  public string? Author { get; set; }
  // If null, we can equate the author to being unknown
}