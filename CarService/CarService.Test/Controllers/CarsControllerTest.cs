
namespace CarService.Test.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using CarService.Controllers;
    using CarService.Data.Models;
    using CarService.Models.Reviews;
    using FluentAssertions;
    using MyTested.AspNetCore.Mvc;
    using Xunit;


    public class CarsControllerTest
    {
        [Fact]
        public void CarsShouldBeForAuthorizedUsersAndReturnView()
           => MyController<CarsController>
               .Instance()
               .Calling(c => c.Add())
               .ShouldHave()
               .ActionAttributes(attributes => attributes
                   .RestrictingForAuthorizedRequests())
               .AndAlso()
               .ShouldReturn()
               .View();

      // [Theory]
      // [InlineData("zaz","968","AA1111AA",1970,"Url",1)]
      // public void PostAddShouldBeForAuthorizedUsersAndReturnView(
      //                                           string make
      //                                           ,string model
      //                                            ,string platenumber
      //                                            , int year
      //                                             ,string imageUrl
      //                                             ,int issueTypeId)                                                   
      //  => MyController<CarsController>
      //      .Instance(controller => controller
      //          .WithUser())
      //      .Calling(c => c.Add(new Models.Cars.AddCarFormModel
      //      {
      //          Make=make,
      //          Model=model,
      //          PlateNumber=platenumber,
      //          Year=year,
      //          ImageUrl=imageUrl,
      //          IssueTypeId=issueTypeId
      //      }))
      //      .ShouldHave()
      //      .ActionAttributes(attributes => attributes
      //         .RestrictingForHttpMethod(HttpMethod.Post)
      //          .RestrictingForAuthorizedRequests())
      //        .Data(data => data
      //           .WithSet<Car>(r => r
      //              .Any(s =>
      //              )))
      //      .AndAlso()
      //      .ShouldReturn()
      //      .RedirectToAction("AllReviews", "Reviews");

    }
}
