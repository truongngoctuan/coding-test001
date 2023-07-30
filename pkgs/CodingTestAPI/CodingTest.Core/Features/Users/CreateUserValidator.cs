using System;
using FluentValidation;

namespace CodingTest.Core.Features.Users
{
	public class CreateUserValidator: AbstractValidator<CreateUserRequest>
	{
		public CreateUserValidator()
		{
			RuleFor(p => p.FirstName)
				.NotEmpty().WithMessage("{PropertyName} is required.")
				.NotNull()
				.MaximumLength(100).WithMessage("{PropertyName} must not exceed 100 characters.");
            RuleFor(p => p.LastName)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(100).WithMessage("{PropertyName} must not exceed 100 characters.");
    }
  }
}

