
namespace CarService.Models.Orders
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class CreateOrderViewModel
    {
        public string UserId { get; set;}

        public decimal TotalPrice { get; set; }

        public IEnumerable<WorkViewModel> Works { get; set; }
    }
}
