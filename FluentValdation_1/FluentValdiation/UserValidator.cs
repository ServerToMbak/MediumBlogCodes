using FluentValdation_1.Entities;
using FluentValidation;

namespace FluentValdation_1.FluentValdiation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.Email).NotEmpty().WithMessage("Your valdiation message here");
            RuleFor(u => u.Email).EmailAddress();

            RuleFor(u => u.LastName).MaximumLength(12);
            RuleFor(u => u.LastName).NotEmpty();

            RuleFor(u => u.FirstName).NotEmpty().MinimumLength(2).MaximumLength(20);

            RuleFor(u => u.BirthDate).NotEmpty();

        }
    }
}
