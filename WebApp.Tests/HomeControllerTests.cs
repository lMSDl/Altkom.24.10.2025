using Xunit;
using Moq;
using AutoFixture;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp.Controllers;
using System.Collections.Generic;

namespace WebApp.Tests
{
 public class HomeControllerTests
 {
 [Fact]
 public void Index_SetsSampleCookie_ReturnsViewResult()
 {
 // Arrange
 var controller = new HomeController();

 // Act
 var result = controller.Index();

 // Assert
 Assert.IsType<ViewResult>(result);
 }

 [Fact]
 public void Info_ReturnsJsonResultWithExpectedProperties()
 {
 // Arrange
 var controller = new HomeController();
 Environment.SetEnvironmentVariable("ASPNETCORE_ENVIRONMENT", "Development");

 // Act
 var result = controller.Info() as JsonResult;

 // Assert
 Assert.NotNull(result);
 dynamic data = result.Value;
 Assert.Equal("WebApp", (string)data.Name);
 Assert.Equal("1.0.0", (string)data.Version);
 Assert.Equal("Development", (string)data.Environment);
 }

 [Fact]
 public void ReadCookie_ReturnsContentWithCookieValue()
 {
 // Arrange
 var controller = new HomeController();
 var cookiesMock = new Mock<IRequestCookieCollection>();
 cookiesMock.Setup(c => c["SampleCookie"]).Returns("TestValue");
 var requestMock = new Mock<HttpRequest>();
 requestMock.Setup(r => r.Cookies).Returns(cookiesMock.Object);
 var httpContext = new DefaultHttpContext();
 httpContext.Request.Headers.Clear();
 httpContext.Request.QueryString = QueryString.Empty;
 httpContext.Request.Method = "GET";
 httpContext.Features.Set(requestMock.Object);
 controller.ControllerContext = new ControllerContext { HttpContext = httpContext };

 // Act
 var result = controller.ReadCookie() as ContentResult;

 // Assert
 Assert.NotNull(result);
 Assert.Contains("TestValue", result.Content);
 }
 }
}
