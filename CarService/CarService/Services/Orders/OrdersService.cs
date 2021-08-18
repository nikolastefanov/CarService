
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
            var userIdCar = this.data.Cars
                .Where(x => x.Id == carId && x.IsDelete==false)
                .Select(x => x.UserId)
                .FirstOrDefault();

            var orderId = this.data.Orders
             .Where(x => x.UserId == userIdCar && x.IsDelete==false)
             .Select(x=>x.Id)
             .FirstOrDefault();

        
            var order = this.data
                .Orders
                .Where(x => x.UserId == userIdCar && x.Id==orderId && x.IsDelete==false)
                .FirstOrDefault();
            


            var vr = this.data
             .Works
             .Where(x => x.Id == workId && x.IssueId == issueId && x.IsDelete==false)
             .FirstOrDefault();
            ;
            vr.OrderId = orderId;
            
            this.data.SaveChanges();

            order.Works.ToList().Add(vr);

            order.TotalPrice += vr.Price;
            ;
            this.data.SaveChanges();

        }

        public void CreateOrderZero(decimal price,string userId)
        {

            var orderData = new Order
            {
                TotalPrice = 0.0M,
                UserId=userId,
                CreateOn=DateTime.UtcNow,
                IsDelete=false,
            };
              

            this.data.Orders.Add(orderData);

            this.data.SaveChanges();
        }

      //  public void DeleteOrderService(string orderId, string userId)
      //  {
      //      var order = this.data
      //        .Orders
      //        .Where(x => x.Id == orderId && x.UserId == userId && x.IsDelete==false)
      //         .FirstOrDefault();
      //
      //      order.IsDelete = true;
      //
      //      this.data.SaveChanges();
      //
      //  }

        public DetailsOrderServiceModel DetailsOrder(string orderId, string userId)
        {
            var order = this.data
               .Orders
               .Where(x => x.Id == orderId && x.UserId == userId && x.IsDelete==false)
               .Select(x => new DetailsOrderServiceModel
               {
                   Id=x.Id,
                   TotalPrice=x.TotalPrice,
                   UserId=x.UserId,
                   CreateOn=x.CreateOn,
                  Works=x.Works
                  .Where(w=>w.IsDelete==false)
                  .Select(w=>new WorkServiceModel
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
             .Where(x=> x.Orders.Count()!=0)
             .Select(x => new AdminOrderServiceModel
             {
                 UserName = x.UserName,
                 OrdersAdmin = x.Orders
                 .Where(x=>x.IsDelete==false)
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
                .Where(x => x.UserId == userId && x.IsDelete==false)
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

        public bool OrderExists(string userId)
        {
            var order = this.data
                        .Orders
                        .Where(x => x.UserId == userId && x.IsDelete==false)
                        .FirstOrDefault();

            if (order==null)
            {
                return false;
            }

            return true;
        }
    }
}
