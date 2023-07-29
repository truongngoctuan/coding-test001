using System;
using CodingTest.Domain.Entities;

namespace CodingTest.Core.Contracts.Persistences
{
	public interface IUserRepository : IAsyncRepository<UserEntity>
	{
	}
}

