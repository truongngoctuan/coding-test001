using System.Collections.Generic;
using MediatR;

namespace CodingTest.Core.Features.Users
{
    public class GetUsersRequest: IRequest<IEnumerable<UserVM>>
	{
		public GetUsersRequest()
		{
		}
	}
}

