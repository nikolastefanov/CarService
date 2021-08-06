
namespace CarService.Controllers
{
    using CarService.Models.Orders;
    using CarService.Services.Orders;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Authentication;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class OrdersController : Controller
    {
        private readonly IOrdersService ordersService;
        private readonly IdentityUser user;
        public OrdersController(IOrdersService ordersService,IdentityUser user)
        {
            this.ordersService = ordersService;
            this.user = user;
        }

        public IActionResult CreateOrder()
        {
            return this.View(new CreateOrderGetViewModel { });
        }

        [HttpPost]
        public IActionResult CreateOrder(CreateOrderViewModel order)
        {

          
            this.ordersService.CreateOrderZero(order.TotalPrice,order.UserId);

           // return this.RedirectToAction("AllOrderws");

            return this.RedirectToAction("/IssueTypes/IndexIssueType");
        }

        public IActionResult AddToOrder(int workId,int issueId,int carId)
        {
            this.ordersService.AddWorkToOrder(workId, issueId, carId);

            return this.RedirectToAction("AllWorks","Works");
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
