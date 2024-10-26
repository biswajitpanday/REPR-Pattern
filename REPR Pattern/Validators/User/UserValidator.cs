using FastEndpoints;
using FluentValidation;
using REPR_Pattern.Requests.Users;

namespace REPR_Pattern.Validators.User;

public class UserValidator : Validator<CreateUserRequest>
{
    public UserValidator()
    {
        RuleFor(u => u.FirstName)
            .NotEmpty()
            .WithMessage("FirstName can't be empty")
            .MinimumLength(4)
            .WithMessage("FirstName must be minimum 4 characters long");

        RuleFor(u => u.Email)
            .NotEmpty()
            .WithMessage("Email can't be empty")
            .EmailAddress()
            .WithMessage("Invalid Email address");
    }
}