
namespace CarService.Services.Orders
{
    using CarService.Services.Works;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;


    public class OrderServiceModel
    {
        public string Id { get; set; }

        public string UserId { get; set; }

        public decimal TotalPrice { get; set; }

        public DateTime CreateOn { get; set; }


    }
}
