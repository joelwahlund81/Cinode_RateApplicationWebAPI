using Cinode_RateApplicationWebAPI.Controllers;
using Cinode_RateApplicationWebAPI.Models;
using Cinode_RateApplicationWebAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Cinode_RateApplication.Tests
{
    public class ProfileControllerTest
    {
        private Mock<IProfileRepository> profileRepoMock;

        public ProfileControllerTest()
        {
            profileRepoMock = new Mock<IProfileRepository>();
        }

        [Fact]
        public async Task ShouldReturnProfileWhenGettingProfileThatDoesExist()
        {
            // Arrange
            var id = 1;
            profileRepoMock.Setup(x => x.Get(It.IsAny<int>())).ReturnsAsync(() => new Profile { Id = id });
            var profileController = new ProfileController(profileRepoMock.Object);

            // Act
            var result = await profileController.GetProfile(1);

            // Assert
            Assert.IsType<OkObjectResult>((OkObjectResult)result);
            var okObjectResult = result as OkObjectResult;
            Assert.IsAssignableFrom<Profile>(okObjectResult.Value);
            Assert.NotNull(okObjectResult.Value);
            Assert.Equal(StatusCodes.Status200OK, okObjectResult.StatusCode);
        }


        [Fact]
        public async Task ShouldReturnServerErrorWhenGettingProfileGoesWrong()
        {
            // Arrange
            profileRepoMock.Setup(x => x.Get(It.IsAny<int>())).Throws(new Exception());
            var profileController = new ProfileController(profileRepoMock.Object);

            // Act
            var result = await profileController.GetProfile(1);

            // Assert
            Assert.IsType<ObjectResult>((ObjectResult)result);
            var serverError = result as ObjectResult;
            Assert.IsAssignableFrom<Exception>(serverError.Value);
            Assert.Equal(StatusCodes.Status500InternalServerError, serverError.StatusCode);
        }

        [Fact]
        public async Task ShouldReturnServerErrorWhenOnPost()
        {
            // Arrange
            profileRepoMock.Setup(x => x.Create(It.IsAny<Profile>())).Throws(new Exception(""));
            var profileController = new ProfileController(profileRepoMock.Object);

            // Act
            var result = await profileController.PostProfile(new Profile());

            // Assert
            Assert.IsType<ObjectResult>((ObjectResult)result);
            var serverError = result as ObjectResult;
            Assert.IsAssignableFrom<Exception>(serverError.Value);
            Assert.Equal(StatusCodes.Status500InternalServerError, serverError.StatusCode);
        }
    }
}
