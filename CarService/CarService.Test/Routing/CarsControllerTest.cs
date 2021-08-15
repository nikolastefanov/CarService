
namespace CarService.Test.Routing
{
    using CarService.Controllers;
    using CarService.Data.Models;
    using CarService.Models.Cars;
    using MyTested.AspNetCore.Mvc;
    using Xunit;

    public class CarsControllerTest
    {
        [Fact]
        public void GetAddShouldBeMapped()
            => MyRouting
                .Configuration()
                .ShouldMap("/Cars/Add")
                .To<CarsController>(c => c.Add());

        [Fact]
        public void PostAddShouldBeMapped()
            => MyRouting
                .Configuration()
                .ShouldMap(request => request
                    .WithPath("/Cars/Add")
                    .WithMethod(HttpMethod.Post))
                .To<CarsController>(c => c.Add(With.Any<AddCarFormModel>()));

   //      [Fact]
   //      public void GetEditShouldBeMapped()
   //         => MyRouting
   //             .Configuration()
   //             .ShouldMap("/Cars/Edit")
   //             .To<CarsController>(c => c.Edit(1));

      // [Fact]
      // public void PostEditShouldBeMapped()
      //     => MyRouting
      //         .Configuration()
      //         .ShouldMap(request => request
      //             .WithPath("/Cars/Edit")
      //             .WithMethod(HttpMethod.Post))
      //         .To<CarsController>(c =>
      //         c.Edit(With.Value<EditCarViewModel>(1,EditCarViewModel car)));
          



        [Fact]
        public void GetCarsShouldBeMapped()
           => MyRouting
               .Configuration()
               .ShouldMap("/Cars/All")
               .To<CarsController>(c => c.All());
    }
}
