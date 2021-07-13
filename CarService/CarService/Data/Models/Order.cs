
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
        }
        public string Id { get; set; }

        public int CarId { get; set; }

        public Car Car { get; set; }

        public ICollection<Work> Works { get; set; }

        public ICollection<SparePart> SpareParts { get; set; }

    }
}
