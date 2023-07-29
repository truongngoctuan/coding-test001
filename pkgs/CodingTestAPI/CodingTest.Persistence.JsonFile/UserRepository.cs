using System;
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

        IDocumentCollection<UserEntity> getCollection()
        {
            // Open database (create new if file doesn't exist)
            var store = new DataStore("data.json");

            // Get employee collection
            var collection = store.GetCollection<UserEntity>();

            return collection;
        }

        public async Task<UserEntity> AddAsync(UserEntity entity)
        {
            var collection = getCollection();
            await collection.InsertOneAsync(entity);
            return entity;
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserEntity>> GetAllAsync()
        {
            var collection = getCollection();
            return Task.FromResult<IEnumerable<UserEntity>>(collection.AsQueryable().AsEnumerable<UserEntity>());
        }

        public Task<UserEntity> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(UserEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}

