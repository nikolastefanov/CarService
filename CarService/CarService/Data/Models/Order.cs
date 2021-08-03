
namespace CarService.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;


    public class Order
    {
        public Order()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Works = new HashSet<Work>();

        }
        public string Id { get; set; }

        public decimal TotalPrice { get; set; }

        public DateTime CreateOn { get; set; }

        public string UserId { get; set; }

        public User User { get; set; }

        public IEnumerable<Work> Works { get; set; }



    }
}
