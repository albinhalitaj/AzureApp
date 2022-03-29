namespace AzureApp.Tests.Controllers
{
    using AzureApp.Controllers;
    using Microsoft.AspNetCore.Mvc;
    using Xunit;

    public class HomeControllerTests
    {
        private readonly HomeController _homeController;
        public HomeControllerTests()
        {
            _homeController = new HomeController();
        }

        [Fact]
        public void HomeController_ShouldReturn_View()
        {

            // act 
            var result = _homeController.Index();

            //asset
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Privacy_ShouldReturn_View()
        {
            var result = _homeController.Privacy();

            Assert.IsType<ViewResult>(result);
        }
    }
}
