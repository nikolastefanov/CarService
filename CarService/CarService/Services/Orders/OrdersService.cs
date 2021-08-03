
namespace CarService.Services.Orders
{
    using CarService.Data;
    using CarService.Data.Models;
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

        public void CreateOrderZero(decimal price)
        {
            var orderData = new Order
            {
                TotalPrice = 0.0M,
            };
              

            this.data.Orders.Add(orderData);

            this.data.SaveChanges();
        }
    }
}
