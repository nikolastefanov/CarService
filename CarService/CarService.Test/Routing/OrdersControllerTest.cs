
namespace CarService.Test.Routing
{
    using CarService.Controllers;
    using MyTested.AspNetCore.Mvc;
    using Xunit;

    public class OrdersControllerTest
    {
        [Fact]
        public void CreateOrderRouteShouldBeMapped()
            => MyRouting
                .Configuration()
                .ShouldMap("/Orders/CreateOrder")
                .To<OrdersController>(c => c.CreateOrder());


    }
}
