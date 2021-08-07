
namespace CarService.Models.Orders
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class AllOrdersViewModel
    {
        public string UserName { get; set; }

        public IEnumerable<OrderViewModel> Orders { get; set; }

    }
}
