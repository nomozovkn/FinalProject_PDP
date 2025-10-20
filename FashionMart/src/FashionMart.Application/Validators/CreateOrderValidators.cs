using FashionMart.Application.DTOs;
using FluentValidation;

namespace FashionMart.Application.Validators;

public class CreateOrderValidators : AbstractValidator<CreateOrderDto>
{
    public CreateOrderValidators()
    {
        RuleFor(x => x.UserId)
            .GreaterThan(0).WithMessage("UserId must be greater than 0.");
        RuleFor(x => x.ProductIds)
            .NotEmpty().WithMessage("ProductIds cannot be empty.")
            .Must(ids => ids.All(id => id > 0)).WithMessage("All ProductIds must be greater than 0.");
    }
}
