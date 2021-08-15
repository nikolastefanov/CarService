
namespace CarService.Test.Controllers
{
    using System;
    using System.Collections.Generic;
    using CarService.Controllers;
 
    using FluentAssertions;
    using MyTested.AspNetCore.Mvc;
    using Xunit;


    public class HomeControllerTest
    {



        [Fact]
        public void ErrorShouldReturnView()
            => MyController<HomeController>
                .Instance()
                .Calling(c => c.Error())
                .ShouldReturn()
                .View();

        [Fact]
        public void IndexActionShouldReturnCorrectView()
            => MyController<HomeController>
            .Instance()
            .Calling(c => c.Index())
            .ShouldReturn()
            .View();

    }
}
