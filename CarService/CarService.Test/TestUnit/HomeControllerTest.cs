
namespace CarService.Test.TestUnit
{
    using CarService.Controllers;
    using Microsoft.AspNetCore.Mvc;
    using Xunit;

    public class HomeControllerTest
    {
        [Fact]
        public void ErrorShouldReturnView()
        {
            //Arange
            var homeController = new HomeController();

            //Act
            var result = homeController.Error();

            //Assert
            Assert.NotNull(result);
            Assert.IsType<ViewResult>(result);

        }


        [Fact]
        public void IndexShouldReturnView()
        {
            //Arange
            var homeController = new HomeController();

            //Act
            var result = homeController.Index();

            //Assert
            Assert.NotNull(result);
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void PrivacyShouldReturnView()
        {
            //Arange
            var homeController = new HomeController();

            //Act
            var result = homeController.Privacy();

            //Assert
            Assert.NotNull(result);
            Assert.IsType<ViewResult>(result);
        }
    }
}
