
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CodingTest.Core.Contracts.Persistences;
using CodingTest.Core.Features.Author;

namespace CodingTest.Core.Features.Books;

public class GetBooksHandler : IRequestHandler<GetBooksRequest, IEnumerable<BookDTO>>
{
  public GetBooksHandler(IBookRepository bookRepository)
  {
    _bookRepository = bookRepository;
  }

  private IBookRepository _bookRepository { get; }

  public async Task<IEnumerable<BookDTO>> Handle(GetBooksRequest request, CancellationToken cancellationToken)
  {
    var validator = new GetBooksValidator();
    var validationResult = await validator.ValidateAsync(request);
    if (validationResult.Errors.Count > 0)
    {
      throw new Exceptions.ValidationException(validationResult);
    }

    var query = (await _bookRepository.GetAllAsync())
      .Where(b => string.IsNullOrEmpty(request.Search) ||
        b.Title.Contains(request.Search) || 
        (!string.IsNullOrEmpty(b.Description) && b.Description.Contains(request.Search)));

    var books = query
        .Skip(request.PageSize * (request.Page - 1))
        .Take(request.PageSize);

    var totalCount = query.Count();

    return books.Select(b => new BookDTO
    {
      Id = b.BookId,
      Author = new AuthorDTO
      {
        Id = b.Author.AuthorId,
        Name = b.Author.Name
      },
      Title = b.Title,
      Description = b.Description
    });
  }
}