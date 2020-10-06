using Cinode_RateApplicationWebAPI.Models;
using FluentValidation;

namespace Cinode_RateApplicationWebAPI.Validators
{
    public class ProfileValidator : AbstractValidator<Profile>
    {
        public ProfileValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("Please specify a first name.");
            RuleFor(x => x.FirstName).MaximumLength(50).WithMessage("First name is too long.");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Please specify a last name.");
            RuleFor(x => x.LastName).MaximumLength(50).WithMessage("Last name is too long.");

            RuleFor(x => x.Skills).Must(x => x.Count >= 5).WithMessage("Must have atleast 5 skills.");
        }
    }
}
