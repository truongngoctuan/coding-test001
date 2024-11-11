using CodingTest.Core.Features.Author;

namespace CodingTest.Core.Features.Books;

public class BookDTO
{
  public int Id { get; set; }
  public AuthorDTO? Author { get; set; }
  public required string Title { get; set; }
  public string? Description { get; set; }
}