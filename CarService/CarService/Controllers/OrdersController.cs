
namespace CarService.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class OrdersController : Controller
    {
        public IActionResult CreateOrder()
        {


            return this.View();
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
