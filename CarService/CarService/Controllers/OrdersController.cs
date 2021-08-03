
namespace CarService.Controllers
{
    using CarService.Models.Orders;
    using CarService.Services.Orders;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class OrdersController : Controller
    {
        private readonly IOrdersService ordersService;

        public OrdersController(IOrdersService ordersService)
        {
            this.ordersService = ordersService;
        }

        public IActionResult CreateOrder()
        {
            return this.View(new CreateOrderGetViewModel { });
        }

        [HttpPost]
        public IActionResult CreateOrder(CreateOrderViewModel order)
        {
            this.ordersService.CreateOrderZero(order.TotalPrice);

            return this.RedirectToAction("/IssueTypes/IndexIssueType");
        }
        public IActionResult AllOrders()
        {


            return this.View();
        }

        public IActionResult DetailsOrder()
        {


            return this.View();
        }


        public IActionResult DeleteOrder()
        {


            return this.View();
        }
    }
}
