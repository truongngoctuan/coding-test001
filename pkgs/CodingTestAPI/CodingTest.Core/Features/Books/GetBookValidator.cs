namespace CodingTest.Core.Features.Books;

public class GetBooksValidator : AbstractValidator<GetBooksRequest>
{
	public GetBooksValidator()
	{
		RuleFor(p => p.Page)
			.GreaterThanOrEqualTo(1).WithMessage("{PropertyName} must be greater than or equal to 1.");

		RuleFor(p => p.PageSize)
			.GreaterThanOrEqualTo(1).WithMessage("{PropertyName} must be greater than or equal to 1.");

    RuleFor(p => p.Search)
      .MaximumLength(100).WithMessage("{PropertyName} must not exceed 100 characters.");
	}
}
