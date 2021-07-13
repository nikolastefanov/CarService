
namespace CarService.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class SparePart
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Manufacturer { get; set; }

        public decimal Price { get; set; }

        public string OrderId { get; set; }

        public Order Order { get; set; }

        public int Available { get; set; }
    }
}
