
namespace CarService.Services.Orders
{
    using CarService.Data;
    using CarService.Data.Models;
    using CarService.Services.Orders.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class OrdersService : IOrdersService
    {
        private readonly ApplicationDbContext data;


        public OrdersService(ApplicationDbContext data)
        {
            this.data = data;
        }

        public void AddWorkToOrder(string userId,int workId, int issueId, int carId)
        {
            var orderId = this.data.Orders
            .Where(x => x.UserId == userId)
            .Select(x => x.Id)
            .FirstOrDefault();


           //var work = this.data
           //     .Issues
           //     .Where(x => x.Id == issueId && x.CarId == carId)
           //     .Select(s => s.Works
           //                 .Where(x => x.Id == workId)
           //                 .Select(w => new  WorkServiceModel
           //                 {
           //                     Id = w.Id,
           //                     Description = w.Description,
           //                     IssueId = w.IssueId,
           //                     Price = w.Price,
           //                     OrderId=orderId,
           //                 })
           //                 .FirstOrDefault()
           //    ).FirstOrDefault();
           //

           // var workList = this.data
           //     .Issues
           //     .Where(x => x.Id == issueId && x.CarId == carId)
           //     .Select(s => s.Works
           //                 .Where(x => x.Id == workId)
           //                 .ToList());
           // 

            var order = this.data
                .Orders
                .Where(x => x.UserId == userId && x.Id==orderId)
                .FirstOrDefault();
            


            var vr = this.data
             .Works
             .Where(x => x.Id == workId && x.IssueId == issueId)
             .FirstOrDefault();

            vr.OrderId = orderId;
            this.data.SaveChanges();

            order.Works.ToList().Add(vr);
            order.TotalPrice += vr.Price;
            this.data.SaveChanges();

        }

        public void CreateOrderZero(decimal price,string userId)
        {
            var orderData = new Order
            {
                TotalPrice = 0.0M,
                UserId=userId,
                CreateOn=DateTime.UtcNow,
            };
              

            this.data.Orders.Add(orderData);

            this.data.SaveChanges();
        }

        public void DeleteOrderService(string orderId, string userId)
        {
            var order = this.data
              .Orders
              .Where(x => x.Id == orderId && x.UserId == userId)
               .FirstOrDefault();


            this.data.Orders.Remove(order);

            this.data.SaveChanges();

        }

        public DetailsOrderServiceModel DetailsOrder(string orderId, string userId)
        {
            var order = this.data
               .Orders
               .Where(x => x.Id == orderId && x.UserId == userId)
               .Select(x => new DetailsOrderServiceModel
               {
                   Id=x.Id,
                   TotalPrice=x.TotalPrice,
                   UserId=x.UserId,
                   CreateOn=x.CreateOn,
                  Works=x.Works.Select(w=>new WorkServiceModel
                  {
                      Id=w.Id,
                      IssueId=w.IssueId,
                      Description=w.Description,
                      Price=w.Price,
                  }).ToList()
               }).FirstOrDefault();


            return order;
        }

        public IEnumerable<AdminOrderServiceModel> GetAllAdmin()
        {
            var orders = this.data
               .Users
               .Select(x => new AdminOrderServiceModel
               {
                   UserName = x.UserName,
                   OrdersAdmin = x.Orders
                   .Select(o => new OrderServiceModel
                   {
                       Id = o.Id,
                       UserId = o.UserId,
                       TotalPrice = o.TotalPrice,
                       CreateOn = o.CreateOn,
                   }).ToList()
               }).ToList(); ;
        


            return orders;
        }

        public IEnumerable<OrderServiceModel> GetAllOrders(string userId)
        {
            var orders = this.data
                .Orders
                .Where(x => x.UserId == userId)
                .Select(x => new OrderServiceModel
                {
                    Id = x.Id,
                    UserId = x.UserId,
                    TotalPrice = x.TotalPrice,
                    CreateOn = x.CreateOn,
                })
                .ToList();

            return orders;
        }



        public string GetUserByName(string userId)
        {
            var userName = this.data
                .Users
                .Where(x => x.Id == userId)
                .Select(x=>x.UserName)
                .FirstOrDefault();

                return userName;
        }
    }
}
