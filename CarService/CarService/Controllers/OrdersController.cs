
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
    using Microsoft.AspNetCore.Authorization;

    using static WebConstants;
    using CarService.Services.Mechanics;

    public class OrdersController : Controller
    {
        private readonly IOrdersService ordersService;
        private readonly IMechanicsService mechanicsService;
    
        public OrdersController(IOrdersService ordersService,
            IMechanicsService mechanicsService)
        {
            this.ordersService = ordersService;
            this.mechanicsService = mechanicsService;
        
        }

        [Authorize]
        public IActionResult CreateOrder()
        {
            return this.View(new CreateOrderGetViewModel { });
        }

        [Authorize]
        [HttpPost]
        public IActionResult CreateOrder(CreateOrderViewModel order)
        {
            var userId = this.User.GetId();
          
            var userIsMechanic = mechanicsService.IsMechanic(userId);
           


            if (User.IsAdmin())
            {
                return Redirect("/Admin/Orders/AllOrderAdmin");
            }

            if (userIsMechanic)
            {
                return Redirect("/IssueTypes/IndexIssueType");
            }

            var isOrder=this.ordersService.OrderExists(userId);

            if (isOrder)
            {
                return Redirect("/IssueTypes/IndexIssueType");
            }
          
            this.ordersService.CreateOrderZero(order.TotalPrice,userId);


            return Redirect("/Cars/All");
        }

        [Authorize]
        public IActionResult AddToOrder(int workId,int issueId,int carId)
        {
            var userId = this.User.GetId();

            this.ordersService.AddWorkToOrder(userId,workId, issueId, carId);

            return Redirect($"/Works/AllWorks?issueId={issueId}&carId={carId}");
        }
        

        [Authorize]
        public IActionResult AllOrders()
        {
            var userId = this.User.GetId();

            var userIsMechanic = mechanicsService.IsMechanic(userId);

            if ( User.IsAdmin())
            {
                return Redirect("/Admin/Orders/AllOrderAdmin");
            }

            if (userIsMechanic)
            {
                return Redirect("/IssueTypes/IndexIssueType");
            }

            if(!this.ordersService.OrderExists(userId))
            {
                return Redirect("/IssueTypes/IndexIssueType");
            }

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

        [Authorize]
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

        [Authorize(Roles = AdministratorRoleName)]
        public IActionResult DeleteOrder(string orderId,string userId)
        {
      
            this.ordersService.DeleteOrderService(orderId, userId);
      
            return this.RedirectToAction("AllOrders","Orders");
        }
    }
}
