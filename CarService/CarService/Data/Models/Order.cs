
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
            this.SpareParts = new HashSet<SparePart>();
            this.Works = new HashSet<Work>();

        }
        public string Id { get; set; }

        public decimal PriceWork { get; set; }

        public decimal PriceSparePart { get; set; }

        public decimal TotalPrice { get; set; }

        public int CarId { get; set; }

        public Car Car { get; set; }

        public string UserId { get; set; }

        public User User { get; set; }

        public IEnumerable<Work> Works { get; set; }

        public IEnumerable<SparePart> SpareParts { get; set; }

    }
}
