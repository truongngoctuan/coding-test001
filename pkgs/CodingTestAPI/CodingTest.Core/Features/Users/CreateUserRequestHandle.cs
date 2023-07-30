using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using CodingTest.Core.Contracts.Persistences;
using CodingTest.Domain.Entities;
using MediatR;

namespace CodingTest.Core.Features.Users
{
  public class CreateUserRequestHandle : IRequestHandler<CreateUserRequest, UserVM>
  {
    private IMapper _mapper { get; set; }
    private IUserRepository _userRepository { get; set; }
    public CreateUserRequestHandle(IMapper mapper, IUserRepository userRepository)
    {
      _mapper = mapper;
      _userRepository = userRepository;
    }

    public async Task<UserVM> Handle(CreateUserRequest request, CancellationToken cancellationToken)
    {
      var validator = new CreateUserValidator();
      var validationResult = await validator.ValidateAsync(request);
      if (validationResult.Errors.Count > 0)
      {
        throw new Exceptions.ValidationException(validationResult);
      }

      var userToSave = _mapper.Map<UserEntity>(request);
      userToSave.UserId = Guid.NewGuid();

      var user = await _userRepository.AddAsync(userToSave);
      return _mapper.Map<UserVM>(user);
    }
  }
}

