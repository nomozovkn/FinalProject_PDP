using FashionMart.Application.DTOs;
using FluentValidation;

namespace FashionMart.Application.Validators;

public class CreateProductValidators : AbstractValidator<CreateProductDto>
{
    public CreateProductValidators()
    {
        RuleFor(p => p.Name)
            .NotEmpty().WithMessage("Product name is required.")
            .MaximumLength(100).WithMessage("Product name cannot exceed 100 characters.");
        RuleFor(p => p.Description)
            .NotEmpty().WithMessage("Product description is required.")
            .MaximumLength(500).WithMessage("Product description cannot exceed 500 characters.");
        RuleFor(p => p.Price)
            .GreaterThan(0).WithMessage("Product price must be greater than zero.");
        RuleFor(p => p.CategoryId)
            .GreaterThan(0).WithMessage("A valid CategoryId is required.");
    }
}
