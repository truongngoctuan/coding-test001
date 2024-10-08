using CodingTest.Core.Contracts.Persistences;
using CodingTest.Domain.Entities;
using JsonFlatFileDataStore;
using Microsoft.EntityFrameworkCore;

namespace CodingTest.Persistence.JsonFile
{
  public class BookRepository : IBookRepository
  {
    private readonly BookDbContext context;

    public BookRepository(BookDbContext context)
    {
      this.context = context;
    }

    DbSet<Book> getCollection() => context.Books;

    public async Task<Book> AddAsync(Book entity)
    {
      var collection = getCollection();
      await collection.AddAsync(entity);
      return entity;
    }

    public Task DeleteAsync(Guid id)
    {
      throw new NotImplementedException();
    }

    public Task<IQueryable<Book>> GetAllAsync()
    {
      var collection = getCollection();
      return Task.FromResult(collection.AsNoTracking());
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

