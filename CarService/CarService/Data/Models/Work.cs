
namespace CarService.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;


    public class Work
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public decimal PriceWork { get; set; }

        public int IssueId { get; set; }

        public Issue Issue { get; set; }

        public string OrderId { get; set; }

        public Order Order { get; set; }


    }
}
