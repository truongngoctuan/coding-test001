using CodingTest.Api.Models;
using CodingTest.Core.Features.Books;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ToDoApi.Controllers;

[ApiController]
[Route("[controller]")]
public class BookController : ControllerBase
{
    private readonly ILogger<BookController> _logger;
    public IMediator _mediator { get; set; }

    public BookController(ILogger<BookController> logger, IMediator mediator)
    {
        _logger = logger;
        _mediator = mediator;
    }

    // [HttpGet()]
    // [ProducesResponseType(StatusCodes.Status200OK)]
    // public async Task<ActionResult<IEnumerable<BookVM>>> GetAll()
    // {
    //     var results = await _mediator.Send(new GetBooksRequest());
    //     return Ok(results);
    // }

    [HttpPost()]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<BookVM>> CreateBook(BookParams book)
    {
        var results = await _mediator.Send(new CreateBookRequest
        {
            Title = book.Title,
            Description = book.Description,
        });
        return Ok(results);
    }
}
