using CodingTest.Core.Contracts.Persistences;
using CodingTest.Domain.Entities;
using JsonFlatFileDataStore;

namespace CodingTest.Persistence.JsonFile
{
  public class BookRepository : IBookRepository
	{
		public BookRepository()
		{
		}

    IDocumentCollection<Book> getCollection()
    {
      // Open database (create new if file doesn't exist)
      var store = new DataStore("data-book.json");

      // Get employee collection
      var collection = store.GetCollection<Book>();

      return collection;
    }

    public async Task<Book> AddAsync(Book entity)
    {
      var collection = getCollection();
      await collection.InsertOneAsync(entity);
      return entity;
    }

    public Task DeleteAsync(Guid id)
    {
      throw new NotImplementedException();
    }

    public Task<IEnumerable<Book>> GetAllAsync()
    {
      var collection = getCollection();
      return Task.FromResult<IEnumerable<Book>>(collection.AsQueryable().AsEnumerable<Book>());
    }

    public Task<Book> GetById(Guid id)
    {
      throw new NotImplementedException();
    }

    public Task UpdateAsync(Book entity)
    {
      throw new NotImplementedException();
    }
  }
}

