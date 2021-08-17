
namespace CarService.Areas.Admin.Controllers
{
    using CarService.Areas.Admin.Models;
    using CarService.Models.Orders;
    using CarService.Services.Orders;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using OrderViewModel = Models.OrderViewModel;

    public class OrdersController: AdminController
    {
        private readonly IOrdersService ordersService;

        public OrdersController(IOrdersService ordersService)
        {
            this.ordersService = ordersService;
        }

        public IActionResult AllOrderAdmin()
        {

            var orders = ordersService
                .GetAllAdmin()
                .Select(s => new AdminAllOrdersViewModel
                {
                    UserName=s.UserName,
                    OrdersAdmin=s.OrdersAdmin.Select(x=>new OrderViewModel
                    {
                        Id=x.Id,
                        TotalPrice=x.TotalPrice,
                        CreateOn=x.CreateOn,
                        UserId=x.UserId,
                    }).ToList()
                })
                .ToList();

            return this.View(orders);
        }
    }
}
