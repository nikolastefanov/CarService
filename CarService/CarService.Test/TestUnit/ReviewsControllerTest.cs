

namespace CarService.Test.TestUnit
{
    using AutoMapper;
    using CarService.Data;
    using CarService.Controllers;
    using CarService.Services.Reviews;
    using Microsoft.AspNetCore.Mvc;
    using Moq;
    using Xunit;
    using CarService.Test.Mocks;

    public class ReviewsControllerTest
    {
        [Fact]
        public void CreateShouldReturnView()
        {
            //Arange
            var data = DatabaseMock.Instance;
            var reviewsService = new ReviewsService(Mock.Of<IMapper>(),data);
            var reviewsController = new ReviewsController(Mock.Of<IMapper>(),reviewsService );

            //Act
            var result = reviewsController.Create();

            //Assert
            Assert.NotNull(result);
            Assert.IsType<ViewResult>(result);
        }
    }
}
