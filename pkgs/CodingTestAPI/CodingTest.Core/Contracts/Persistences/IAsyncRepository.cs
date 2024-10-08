using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingTest.Core.Contracts.Persistences
{
	public interface IAsyncRepository<T> where T : class
	{
		Task<IQueryable<T>> GetAllAsync();
		Task<T> GetById(Guid id);
		Task<T> AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(Guid id);
  }
}

