
namespace CarService.Test.Controllers
{
    using System;
    using System.Collections.Generic;
    using CarService.Controllers;

    using FluentAssertions;
    using MyTested.AspNetCore.Mvc;
    using Xunit;


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
               .Instance()
               .Calling(c => c.AddIssueType())
                .ShouldHave()
                .ActionAttributes(attributes => attributes
                    .RestrictingForAuthorizedRequests())
                .AndAlso()
               .ShouldReturn()
               .View();



    }
}
