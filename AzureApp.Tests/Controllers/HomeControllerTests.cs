namespace AzureApp.Tests.Controllers
{
    using AzureApp.Controllers;
    using Microsoft.AspNetCore.Mvc;
    using Xunit;

    public class HomeControllerTests
    {
        [Fact]
        public void HomeController_ShouldReturn_View()
        {
            // arrange
            var controller = new HomeController();

            // act 
            var result = controller.Index();

            //asset
            Assert.IsType<ViewResult>(result);
        }
    }
}
