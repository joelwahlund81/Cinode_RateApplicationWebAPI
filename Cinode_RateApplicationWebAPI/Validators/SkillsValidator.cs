using Cinode_RateApplicationWebAPI.Models;
using FluentValidation;

namespace Cinode_RateApplicationWebAPI.Validators
{
    public class SkillsValidator : AbstractValidator<Skills>
    {
        public SkillsValidator()
        {
            RuleFor(x => x.Skill).NotEmpty().WithMessage("Please specify a skill.");
            RuleFor(x => x.Skill).MaximumLength(50).WithMessage("First name is too long.");
            RuleFor(x => x.Rating).NotNull().WithMessage("Please input a rating.")
                .LessThanOrEqualTo(0).WithMessage("Rating must not be less than or equal to 0.")
                .GreaterThanOrEqualTo(5).WithMessage("Rating must not be greater than 5.");
        }
    }
}
