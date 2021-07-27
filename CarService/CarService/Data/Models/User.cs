
namespace CarService.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;


    public class User : IdentityUser
    {
        public User()
        {
            this.Orders = new HashSet<Order>();
            this.Reviews = new HashSet<Review>();
            this.Cars = new HashSet<Car>();
        }
     

        public IEnumerable<Order> Orders { get; set; }

        public IEnumerable<Review> Reviews { get; set; }

        public IEnumerable<Car> Cars { get; set; }

    }
}


