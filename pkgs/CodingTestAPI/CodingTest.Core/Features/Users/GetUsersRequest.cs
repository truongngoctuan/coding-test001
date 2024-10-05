using System.Collections.Generic;

namespace CodingTest.Core.Features.Users
{
    public class GetUsersRequest: IRequest<IEnumerable<UserVM>>
	{
		public GetUsersRequest()
		{
		}
	}
}

