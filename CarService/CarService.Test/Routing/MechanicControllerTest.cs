
namespace CarService.Test.Routing
{
    using CarService.Controllers;
    using CarService.Models.Mechanics;
    using MyTested.AspNetCore.Mvc;
    using Xunit;

    public class MechanicControllerTest
    {
        [Fact]
        public void GetBecomeShouldBecomeMapper()
          => MyRouting
            .Configuration()
            .ShouldMap("/Mechanics/Become")
            .To<MechanicsController>(c => c.Become());


        [Fact]
        public void PostBecomeShouldBeMapped()
            => MyRouting
             .Configuration()
             .ShouldMap(request => request
                    .WithPath("/Mechanics/Become")
                     .WithMethod(HttpMethod.Post))
                     .To<MechanicsController>(c =>
                       c.Become(With.Any<BecomeMechanicViewModel>()));
    }
}
