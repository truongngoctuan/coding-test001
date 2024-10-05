using System.Threading;
using System.Threading.Tasks;
using CodingTest.Core.Contracts.Persistences;
using CodingTest.Domain.Entities;

namespace CodingTest.Core.Features.Books;

public class CreateBookRequestHandle : IRequestHandler<CreateBookRequest, BookDTO>
{
  private IMapper _mapper { get; set; }
  private IBookRepository _BookRepository { get; set; }
  public CreateBookRequestHandle(IMapper mapper, IBookRepository BookRepository)
  {
    _mapper = mapper;
    _BookRepository = BookRepository;
  }

  public async Task<BookDTO> Handle(CreateBookRequest request, CancellationToken cancellationToken)
  {
    var validator = new CreateBookValidator();
    var validationResult = await validator.ValidateAsync(request);
    if (validationResult.Errors.Count > 0)
    {
      throw new Exceptions.ValidationException(validationResult);
    }

    var bookToSave = _mapper.Map<Book>(request);
    // bookToSave.Id = Guid.NewGuid();

    var Book = await _BookRepository.AddAsync(bookToSave);
    return _mapper.Map<BookDTO>(Book);
  }
}
