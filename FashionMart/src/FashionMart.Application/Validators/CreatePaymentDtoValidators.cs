using FashionMart.Application.DTOs;
using FluentValidation;

namespace FashionMart.Application.Validators;

public class CreatePaymentDtoValidators : AbstractValidator<CreatePaymentDto>
{
    public CreatePaymentDtoValidators()
    {
        RuleFor(p => p.OrderId)
            .GreaterThan(0).WithMessage("OrderId must be greater than zero.");
        RuleFor(p => p.Amount)
            .GreaterThan(0).WithMessage("Amount must be greater than zero.");
        RuleFor(p => p.Method)
            .NotEmpty().WithMessage("Payment method is required.")
            .MaximumLength(50).WithMessage("Payment method cannot exceed 50 characters.");
    }
}
