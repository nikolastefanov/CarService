
namespace CarService.Test.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using CarService.Controllers;
    using CarService.Data.Models;
    using CarService.Models.Reviews;
    using CarService.Models.Works;
    using FluentAssertions;
    using MyTested.AspNetCore.Mvc;
    using Xunit;

    public class WorksControllerTest
    {
        [Fact]
        public void GetAddWorksShouldBeForAuthorizedUsersAndReturnView()
           => MyController<WorksController>
               .Instance()
               .Calling(c => c.AddWorks())
               .ShouldHave()
               .ActionAttributes(attributes => attributes
                   .RestrictingForAuthorizedRequests())
               .AndAlso()
               .ShouldReturn()
               .View();


        [Theory]
        [InlineData(1,1,"desckr",12.21,1,1)]
        public void PostAddWorksShouldBeForAuthorizedUsersAndReturnView(
                                                  int issueId
                                                  ,int carId
                                                   ,string description
                                                   ,decimal price
                                                    ,int carId1
                                                     ,int workId)
         => MyController<WorksController>
             .Instance(controller => controller
                 .WithUser())
             .Calling(c => c.AddWorks(
                  issueId
                 ,carId
                 ,new AddWorkViewModel
             {
                 Description=description,
                 Price=price,
                 IssueId=issueId,
                 CarId=carId1,
             }))
             .ShouldHave()
             .ActionAttributes(attributes => attributes
                .RestrictingForHttpMethod(HttpMethod.Post)
                 .RestrictingForAuthorizedRequests())
               .Data(data => data
                  .WithSet<Works>(w=>w
                  .Any(s=>
                    s.Description==description &&
                     s.Price==price &&
                     s.IssueId==issueId )))
             .AndAlso()
             .ShouldReturn()
              .Redirect($"/Orders/AddToOrder?workId={workId}&issueId={issueId}&carId={carId}");







    }
}
