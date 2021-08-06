
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

        public void AddWorkToOrder(int workId, int issueId, int carId)
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


     
            
        }

        public void CreateOrderZero(decimal price,string userId)
        {
            var orderData = new Order
            {
                TotalPrice = 0.0M,
                UserId=userId,
            };
              

            this.data.Orders.Add(orderData);

            this.data.SaveChanges();
        }
    }
}
