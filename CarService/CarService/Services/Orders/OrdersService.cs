
namespace CarService.Services.Orders
{
    using CarService.Data;
    using CarService.Data.Models;
    using CarService.Services.Works;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class OrdersService : IOrdersService
    {
        private readonly ApplicationDbContext data;


        public OrdersService(ApplicationDbContext data)
        {
            this.data = data;
        }

        public void AddWorkToOrder(string userId,int workId, int issueId, int carId)
        {

            var work = this.data
                 .Issues
                 .Where(x => x.Id == issueId && x.CarId == carId)
                 .Select(s => s.Works
                             .Where(x => x.Id == workId)
                             .Select(w => new WorkServiceModel
                             {
                                 Id = w.Id,
                                 Description = w.Description,
                                 IssueId = w.IssueId,
                                 Price = w.Price,
                             })
                             .FirstOrDefault()
                ).FirstOrDefault();

            var order = this.data
                .Orders
                .Where(x => x.UserId == userId)
                .FirstOrDefault();

              order.TotalPrice += work.Price;
           // order.Works.
            
     

            
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

        public IEnumerable<OrderServiceModel> GetAllOrders(string userId)
        {
            var orders = this.data
                .Orders
                .Where(x => x.UserId == userId)
                .Select(x => new OrderServiceModel
                {
                    Id=x.Id,
                    UserId=x.UserId,
                    TotalPrice=x.TotalPrice,
                    CreateOn=x.CreateOn,                 
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
