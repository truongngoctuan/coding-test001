﻿using Microsoft.Extensions.DependencyInjection;
using CodingTest.Core.Contracts.Persistences;

namespace CodingTest.Persistence.JsonFile
{
  public static class PersistenceRegistration
	{
    public static IServiceCollection AddPersistenceService(this IServiceCollection services)
    {
      services.AddScoped<IUserRepository, UserRepository>();
      return services;
    }
  }
}

