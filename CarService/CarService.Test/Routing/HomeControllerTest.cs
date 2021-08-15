
namespace CarService.Test.Routing
{
    using CarService.Controllers;
    using MyTested.AspNetCore.Mvc;
    using Xunit;

    public class HomeControllerTest
    {
        [Fact]
        public void ErrorRouteShouldBeMapped()
            => MyRouting
              .Configuration()
              .ShouldMap("/Home/Error")
               .To<HomeController>(c => c.Error());

        [Fact]
        public void IndexRouteShouldBeMapped()
           => MyRouting
               .Configuration()
               .ShouldMap("/")
               .To<HomeController>(c => c.Index());
    }
}
