
namespace CarService.Test.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using CarService.Controllers;
    using CarService.Data.Models;
    using CarService.Models.IssueTypes;
    using FluentAssertions;
    using MyTested.AspNetCore.Mvc;
    using Xunit;

    using static WebConstants;
    using static Data.DataConstants.IssueType;


    public class IssueTypesControllerTest
    {
        [Fact]
        public void IssueTypeShouldReturnView()
            => MyController<IssueTypesController>
                .Instance()
                .Calling(c => c.IndexIssueType())
                .ShouldReturn()
                .View();


         [Fact]
         public void GetAddIssueTypeShouldBeForAuthorizedUsersAndReturnView()
            => MyController<IssueTypesController>
                .Instance(controller => controller
                           .WithUser())
                .Calling(c => c.AddIssueType())
                 .ShouldHave()
                 .ActionAttributes(attributes => attributes
                     .RestrictingForAuthorizedRequests())
                     .AndAlso()
                   .ShouldReturn()
                   .RedirectToAction("IndexIssueType");

        [Theory]
        [InlineData("Engine",IssueTypeUrl)]
        public void PostAddIssueTypeShouldBeForAuthorizedUsersAndReturnView(
          string name
          , string image)
          => MyController<IssueTypesController>
              .Instance(controller => controller
                  .WithUser())
              .Calling(c => c.AddIssueType(new IssueTypeViewModel
              {
                  Name=name,
                  ImageUrl=image,
              }))
              .ShouldHave()
              .ActionAttributes(attributes => attributes
                   .RestrictingForHttpMethod(HttpMethod.Post)
                  .RestrictingForAuthorizedRequests())
              .AndAlso()
              .ShouldReturn()
              .RedirectToAction("IndexIssueType");


        
    }
}
