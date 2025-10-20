using FashionMart.Application.DTOs;
using FluentValidation;

namespace FashionMart.Application.Validators;

public class UserLoginValidators : AbstractValidator<LoginDto>
{
    public UserLoginValidators()
    {
        RuleFor(x => x.UserName)
         .NotEmpty()
         .WithMessage("UserName is required")
         .Length(3, 20)
         .WithMessage("UserName must be between 3 and 20 characters long");

        RuleFor(x => x.Password)
            .NotEmpty()
            .WithMessage("Password is required")
            .Length(6, 20)
            .WithMessage("Password must be between 8 and 20 characters long");
    }
}
