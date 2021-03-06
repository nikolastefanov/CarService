
namespace CarService.Models.Orders
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class DetailsOrderViewModel
    {
        public string Id { get; set; }

        public string UserId { get; set; }

        public string UserName { get; set; }

        public decimal TotalPrice { get; set; }

        public DateTime CreateOn { get; set; }

        public IEnumerable<WorkViewModel> Works { get; set; }

    }
}
