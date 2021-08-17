
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


    public class ReviewsControllerTest
    {


        [Fact]
        public void GetCreateShouldBeForAuthorizedUsersAndReturnView()
           => MyController<ReviewsController>
               .Instance()
               .Calling(c => c.Create())
               .ShouldHave()
               .ActionAttributes(attributes => attributes
                   .RestrictingForAuthorizedRequests())
               .AndAlso()
               .ShouldReturn()
               .View();

        [Theory]
        [InlineData("Content")]
        public void PostCreateShouldBeForAuthorizedUsersAndReturnView(
                                                   string content)
          => MyController<ReviewsController>
              .Instance(controller => controller
                  .WithUser())
              .Calling(c => c.Create(new ReviewInputFormModel
              {
                  Content = content,
              }))
              .ShouldHave()
              .ActionAttributes(attributes => attributes
                 .RestrictingForHttpMethod(HttpMethod.Post)
                  .RestrictingForAuthorizedRequests())
                .Data(data => data
                   .WithSet<Review>(r => r
                      .Any(s =>
                      s.Content == content)))
              .AndAlso()
              .ShouldReturn()
              .RedirectToAction("AllReviews", "Reviews");


        [Fact]
        public void AllReviewsShouldBeForAuthorizedUsersAndReturnView()
         => MyController<ReviewsController>
             .Instance()
             .Calling(c => c.AllReviews())
             .ShouldReturn()
             .View();
    }
}
