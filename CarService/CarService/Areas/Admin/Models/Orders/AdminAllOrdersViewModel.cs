

namespace CarService.Areas.Admin.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class AdminAllOrdersViewModel
    {
        public string UserName { get; set; }

        public IEnumerable<OrderViewModel> OrdersAdmin { get; set; }

    }
}
