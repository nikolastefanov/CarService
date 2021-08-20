

namespace CarService.Test.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using CarService.Controllers;
    using CarService.Data.Models;
    using CarService.Models.Cars;
    using CarService.Models.Reviews;
    using FluentAssertions;
    using MyTested.AspNetCore.Mvc;
    using Xunit;

    using static Data.DataConstants.Car;

    public class CarsControllerTest
    {
        [Fact]
        public void GetAddCarsShouldBeForAuthorizedUsersAndReturnView()
           => MyController<CarsController>
               .Instance()
               .Calling(c => c.Add())
               .ShouldHave()
               .ActionAttributes(attributes => attributes
                   .RestrictingForAuthorizedRequests())
               .AndAlso()
               .ShouldReturn()
               .View();


          


        [Fact]
        public void GetAllCarsShouldBeForAuthorizedUsersAndReturnView()
          => MyController<CarsController>
              .Instance(controller => controller
                        .WithUser())
              .Calling(c => c.All())
              .ShouldHave()
              .ActionAttributes(attributes => attributes
                  .RestrictingForAuthorizedRequests())
              .AndAlso()
              .ShouldReturn()
              .View();

      

                      

        
    }
}
