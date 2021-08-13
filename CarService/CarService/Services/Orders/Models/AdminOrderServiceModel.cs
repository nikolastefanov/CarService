
namespace CarService.Services.Orders.Models
{

    using System;
    using System.Collections.Generic;

    public class AdminOrderServiceModel
    {
      public string UserName { get; set; }
      public IEnumerable<OrderServiceModel> OrdersAdmin { get; set; }

    }
}
