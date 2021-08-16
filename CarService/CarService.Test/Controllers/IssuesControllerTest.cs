
namespace CarService.Test.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using CarService.Controllers;
    using CarService.Data.Models;
    using CarService.Models.Issues;
    using FluentAssertions;
    using MyTested.AspNetCore.Mvc;
    using Xunit;

    using static WebConstants;

    public class IssuesControllerTest
    {
        [Fact]
        public void GetAddIssueShouldBeForAuthorizedUsersAndReturnView()
           => MyController<IssuesController>
               .Instance()
               .Calling(c => c.AddIssue(1))
               .ShouldHave()
               .ActionAttributes(attributes => attributes
                   .RestrictingForAuthorizedRequests())
               .AndAlso()
               .ShouldReturn()
               .View();

       [Theory]
       [InlineData("descr", 1)]
        public void PostAddIssueShouldBeForAuthorizedUsersAndReturnView(
           string description
           ,int carId)
           => MyController<IssuesController>
               .Instance(controller=>controller
                   .WithUser())
               .Calling(c => c.AddIssue(new AddIssueViewModel
               {
                   Description="descr",
                   CarId=1,
               },1))
               .ShouldHave()
               .ActionAttributes(attributes => attributes
                   .RestrictingForAuthorizedRequests())
                 .Data(data=>data
                    .WithSet<Issue>(issue=>issue
                            .Any(i=>
                               i.Description ==description &&
                               i.CarId==carId
                                )))
               .AndAlso()
               .ShouldReturn()
               .Redirect("/Issues/AllIssues?carId=1");

        [Fact]
        public void AllIsuueShouldBeForAuthorizedUsersAndReturnView()
          => MyController<IssuesController>
              .Instance()
              .Calling(c => c.AllIssues(1))
              .ShouldHave()
              .ActionAttributes(attributes => attributes
                  .RestrictingForAuthorizedRequests())
              .AndAlso()
              .ShouldReturn()
              .View();


        [Theory]
        [InlineData("descr", 1)]
        public void PostEditIssueShouldBeForAuthorizedUsersAndReturnView(
           string description
           , int carId)
           => MyController<IssuesController>
               .Instance(controller => controller
                   .WithUser())
               .Calling(c => c.AddIssue(new AddIssueViewModel
               {
                   Description = "descr",
                   CarId = 1,
               }, 1))
               .ShouldHave()
               .ActionAttributes(attributes => attributes
                   .RestrictingForAuthorizedRequests())
                 .Data(data => data
                    .WithSet<Issue>(issue => issue
                            .Any(i =>
                               i.Description == description &&
                               i.CarId == carId
                                )))
               .AndAlso()
               .ShouldReturn()
               .Redirect("/Issues/AllIssues?carId=1");



    }
}
