
namespace CarService.Test.TestUnit
{
    using AutoMapper;
    using CarService.Controllers;
    using CarService.Data.Models;
    using CarService.Services.Cars;
    using CarService.Services.Mechanics;
    using CarService.Services.Orders;
    using CarService.Test.Mocks;
    using Microsoft.AspNetCore.Mvc;
    using Moq;
    using System;
    using System.Linq;
    using Xunit;

    public class CarsControllerTest
    {
        [Fact]
        public void AddGetShouldReturnView()
        {
            //Arange
            var data = DatabaseMock.Instance;
            var ordersService = new OrdersService(data);
            var mechanicsService = new MechanicsService(data);
            var carsService = new CarsService(data);
            var carsController = new CarsController(carsService,
                                     ordersService,
                                      mechanicsService,
                                     Mock.Of<IMapper>());

            //Act
            var result = carsController.Add();

            //Assert
            Assert.NotNull(result);
            Assert.IsType<ViewResult>(result);
        }

       
        [Fact]
        public void DetailsShouldReturnView()
        {
            //Arange
            var data = DatabaseMock.Instance;
            var ordersService = new OrdersService(data);
            var mechanicsService = new MechanicsService(data);
            var carsService = new CarsService(data);
            var user = new User();
            data.Users.Add(user);
            var cars = Enumerable
                .Range(0, 10)
                .Select(i => new Car());
            data.Cars.AddRange(cars);
            data.SaveChanges();
            var carsController = new CarsController(carsService,
                                     ordersService,
                                      mechanicsService,
                                     Mock.Of<IMapper>());

            //Act
            var result = carsController.Details(1, "asd");

            //Assert
            Assert.NotNull(result);

        }


        [Fact]
        public void DeleteShouldReturnView()
        {
            //Arange
            var data = DatabaseMock.Instance;
            var ordersService = new OrdersService(data);
            var mechanicsService = new MechanicsService(data);
            var carsService = new CarsService(data);
            var user = new User();
            data.Users.Add(user);
            var cars = Enumerable
                .Range(0, 10)
                .Select(i => new Car());
            data.Cars.AddRange(cars);
            data.SaveChanges();
            var carsController = new CarsController(carsService,
                                     ordersService,
                                      mechanicsService,
                                     Mock.Of<IMapper>());

            //Act
            var result = carsController.DeleteCar(1);

            //Assert
            Assert.NotNull(result);
           
        }

    }
}
