using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using MVC_Client.Controllers;
using MVC_Client.Models;
using MVC_Client.Services;

namespace FrontTest
{
    public class UnitTest1
    {
        [Fact]
        public async Task TestInstallationDetailDAsync_ValidModel()
        {
            // Arrange
            var loggerMock = new Mock<ILogger<HomeController>>();
            var nerServicesMock = new Mock<INerServices>();
            var controller = new HomeController(loggerMock.Object, nerServicesMock.Object);

            var validInstallation = new NewInstallationM
            {
                // Set properties to create a valid model
            };

            // Act
            var result = await controller.InstallationDetailDAsync(validInstallation) as RedirectToActionResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Details", result.ActionName);
            nerServicesMock.Verify(x => x.PostInstallation(validInstallation), Times.Once);
        }


    }
}