using CodingTest.Core.Features.Books;
using CodingTest.Domain.Entities;

namespace CodingTest.Core.Profiles
{
    public class BookProfile: Profile
	{
		public BookProfile()
		{
			CreateMap<Book, BookDTO>();
			CreateMap<CreateBookRequest, Book>();
		}
	}
}