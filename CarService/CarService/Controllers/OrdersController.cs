﻿
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
    using CarService.Infrastructure;

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
            var userId = this.User.GetId();
          
            this.ordersService.CreateOrderZero(order.TotalPrice,userId);

            return this.RedirectToAction("/IssueTypes/IndexIssueType");
        }

        public IActionResult AddToOrder(int workId,int issueId,int carId)
        {
            var userId = this.User.GetId();

            this.ordersService.AddWorkToOrder(userId,workId, issueId, carId);

            return Redirect($"/Works/AllWorks?issueId={issueId}&carId={carId}");
        }
        


        public IActionResult AllOrders()
        {
            var userId = this.User.GetId();

            var orders=this.ordersService.GetAllOrders( userId);

            var userName = this.ordersService.GetUserByName(userId);

            var ordersData = orders
                .Select(x => new AllOrdersViewModel
                {
                    UserName = userName,
                    Orders = orders.Select(s => new OrderViewModel
                    {
                        Id = s.Id,
                        TotalPrice = s.TotalPrice,
                        CreateOn = x.CreateOn,
                        UserId = s.UserId,
                    }).ToList()

                }).FirstOrDefault();

            return this.View(ordersData);
        }

        public IActionResult DetailsOrder(string orderId,string userId)
        {
            var orderDetails = this.ordersService.DetailsOrder(orderId, userId);

            var userName = this.ordersService.GetUserByName(userId);

            var orderView = new DetailsOrderViewModel
            {
                Id = orderDetails.Id,
                UserId = orderDetails.UserId,
                UserName=userName,
                TotalPrice = orderDetails.TotalPrice,
                CreateOn = orderDetails.CreateOn,
                Works = orderDetails.Works.Select(x => new WorkViewModel
                {
                    Id = x.Id,
                    Description = x.Description,
                    Price = x.Price,
                    IssueId = x.IssueId,
                }).ToList()

            };
                


            return this.View(orderView);
        }


        public IActionResult DeleteOrder(string orderId,string userId)
        {

            this.ordersService.DeleteOrderService(orderId, userId);

            return this.View("AllOrders","Orders");
        }
    }
}
