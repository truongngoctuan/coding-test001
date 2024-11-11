
using System.Collections.Generic;

namespace CodingTest.Core.Features.Books;

// TODO improve this class with return values that have indicator for total number or total pages, help to load more data from client side
public class GetBooksRequest : IRequest<IEnumerable<BookDTO>>
{
  public int Page { get; set; }
  public int PageSize { get; set; }
  public string? Search { get; set; }
}

// var result = new
//         {
//             TotalCount = totalCount,
//             TotalPages = totalPages,
//             CurrentPage = page,
//             PageSize = pageSize,
//             Articles = query.ToList()
//         };