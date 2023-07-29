using System;
using AutoMapper;
using CodingTest.Core.Features.Users;
using CodingTest.Domain.Entities;

namespace CodingTest.Core.Profiles
{
	public class UserProfile: Profile
	{
		public UserProfile()
		{
			CreateMap<UserEntity, UserVM>();
		}
	}
}

