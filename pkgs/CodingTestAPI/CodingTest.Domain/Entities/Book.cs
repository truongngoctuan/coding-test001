namespace CodingTest.Domain.Entities
{
    public class Book
    {
        public int BookId { get; set; }
        public required Author Author { get; set; }
        public required string Title { get; set; }
        public string? Description { get; set; }
    }
}
