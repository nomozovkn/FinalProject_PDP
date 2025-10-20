using FashionMart.Application.DTOs;
using FluentValidation;


namespace FashionMart.Application.Validators;

public class CreateCategoryValidators : AbstractValidator<CreateCategoryDto>
{
    public CreateCategoryValidators()
    {
        RuleFor(c => c.Name)
            .NotEmpty().WithMessage("Category name is required.")
            .MaximumLength(100).WithMessage("Category name must not exceed 100 characters.");
        RuleFor(c => c.ParentCategoryId)
            .GreaterThan(0).When(c => c.ParentCategoryId.HasValue)
            .WithMessage("Parent Category ID must be greater than zero if provided.");
    }
}
