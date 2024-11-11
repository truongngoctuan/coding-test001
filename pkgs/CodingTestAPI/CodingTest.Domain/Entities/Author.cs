using System.Collections.Generic;

namespace CodingTest.Domain.Entities
{
    public class Author
    {
        public int AuthorId { get; set; }
        public required string Name { get; set; }
        public ICollection<Book> Books { get; } = new List<Book>();
    }
}
