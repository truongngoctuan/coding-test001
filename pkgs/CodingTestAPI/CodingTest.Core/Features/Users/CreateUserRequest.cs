using MediatR;

namespace CodingTest.Core.Features.Users
{
  public class CreateUserRequest : UserVM, IRequest<UserVM>
  {
  }
}

