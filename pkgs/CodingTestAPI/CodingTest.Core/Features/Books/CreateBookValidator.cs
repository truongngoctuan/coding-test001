namespace CodingTest.Core.Features.Books;

public class CreateBookValidator : AbstractValidator<CreateBookRequest>
{
	public CreateBookValidator()
	{
		RuleFor(p => p.Title)
			.NotEmpty().WithMessage("{PropertyName} is required.")
			.NotNull()
			.MaximumLength(100).WithMessage("{PropertyName} must not exceed 100 characters.");

		RuleFor(p => p.Description)
			.NotNull()
			.MaximumLength(1000).WithMessage("{PropertyName} must not exceed 1000 characters.");
	}
}
