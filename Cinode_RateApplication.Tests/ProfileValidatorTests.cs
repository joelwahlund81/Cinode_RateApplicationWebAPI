using Cinode_RateApplicationWebAPI.Models;
using Cinode_RateApplicationWebAPI.Validators;
using FluentValidation.TestHelper;
using System.Collections.Generic;
using Xunit;

namespace Cinode_RateApplication.Tests
{
    public class ProfileValidatorTests
    {
        private readonly ProfileValidator validator = new ProfileValidator();

        [Fact]
        public void ShouldNotValidateWhenFirstNameIsEmpty()
        {
            validator.ShouldHaveValidationErrorFor(x => x.FirstName, string.Empty);
        }

        [Fact]
        public void ShouldNotValidateWhenFirstNameIsTooLong()
        {
            validator.ShouldHaveValidationErrorFor(x => x.LastName, "Jag är en alldeles för lång sträng och borde inte valideras");
        }

        [Fact]
        public void ShouldNotValidateWhenLastNameIsEmpty()
        {
            validator.ShouldHaveValidationErrorFor(x => x.LastName, string.Empty);
        }

        [Fact]
        public void ShouldNotValidateWhenLastNameIsTooLong()
        {
            validator.ShouldHaveValidationErrorFor(x => x.LastName, "Jag är en alldeles för lång sträng och borde inte valideras");
        }

        [Fact]
        public void ShouldNotValidateWhenSkillsListIsEmpty()
        {
            validator.ShouldHaveValidationErrorFor(x => x.Skills, new List<Skills>());
        }

        [Fact]
        public void ShouldNotValidateWhenSkillsListIsTooShort()
        {
            validator.ShouldHaveValidationErrorFor(x => x.Skills, new List<Skills> { new Skills { }, new Skills { }, new Skills { }, new Skills { } });
        }
    }
}
