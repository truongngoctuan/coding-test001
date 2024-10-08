using CodingTest.Core.Contracts.Persistences;
using CodingTest.Domain.Entities;
using JsonFlatFileDataStore;

namespace CodingTest.Persistence.JsonFile
{
  public class UserRepository : IUserRepository
	{
		public UserRepository()
		{
		}

    IDocumentCollection<User> getCollection()
    {
      // Open database (create new if file doesn't exist)
      var store = new DataStore("data.json");

      // Get employee collection
      var collection = store.GetCollection<User>();

      return collection;
    }

    public async Task<User> AddAsync(User entity)
    {
      var collection = getCollection();
      await collection.InsertOneAsync(entity);
      return entity;
    }

    public Task DeleteAsync(Guid id)
    {
      throw new NotImplementedException();
    }

    public Task<IQueryable<User>> GetAllAsync()
    {
      var collection = getCollection();
      return Task.FromResult(collection.AsQueryable().AsEnumerable().AsQueryable());
    }

    public Task<User> GetById(Guid id)
    {
      throw new NotImplementedException();
    }

    public Task UpdateAsync(User entity)
    {
      throw new NotImplementedException();
    }
  }
}

