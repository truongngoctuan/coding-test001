using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using CodingTest.Core.Contracts.Persistences;
using MediatR;

namespace CodingTest.Core.Features.Users
{
    public class GetUsersRequestHandle: IRequestHandler<GetUsersRequest, IEnumerable<UserVM>>
	{
        private IMapper _mapper { get; set; }
        private IUserRepository _userRepository { get; set; }
        public GetUsersRequestHandle(IMapper mapper, IUserRepository userRepository)
		{
            _mapper = mapper;
            _userRepository = userRepository;
		}

        public async Task<IEnumerable<UserVM>> Handle(GetUsersRequest request, CancellationToken cancellationToken)
        {
            var users = await _userRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<UserVM>>(users);
        }
    }
}

