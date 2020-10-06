using Cinode_RateApplicationWebAPI.Validators;
using FluentValidation.TestHelper;
using Xunit;

namespace Cinode_RateApplication.Tests
{
    public class SkillsValidatorTest
    {
        private readonly SkillsValidator validator = new SkillsValidator();

        [Fact]
        public void ShouldNotValidateWhenSkillIsEmpty()
        {
            validator.ShouldHaveValidationErrorFor(x => x.Skill, string.Empty);
        }

        [Fact]
        public void ShouldNotValidateWhenSkillIsTooLong()
        {
            validator.ShouldHaveValidationErrorFor(x => x.Skill, "Jag är en alldeles för lång sträng och borde inte valideras");
        }

        [Fact]
        public void ShouldNotValidateWhenRatingIsZero()
        {
            validator.ShouldHaveValidationErrorForAsync(x => x.Rating, 0);
        }

        [Fact]
        public void ShouldNotValidateWhenRatingIsMinus()
        {
            validator.ShouldHaveValidationErrorForAsync(x => x.Rating, -1);
        }

        [Fact]
        public void ShouldNotValidateWhenRatingTooHigh()
        {
            validator.ShouldHaveValidationErrorForAsync(x => x.Rating, 6);
        }
    }
}
