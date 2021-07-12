
namespace CarService.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }

        public string PlateNumber { get; set; }
        
        public int Year { get; set; }
        
        public string ImageUrl { get; set; }


        public int UserId { get; set; }

        public User Owner { get; set; }
        
        public ICollection<Issue> Issues { get; set; }

        public ICollection<Order> Orders { get; set; }


        
        //⦁	Has a OwnerId – a string (required)
        //⦁	Has a Owner – a User object
        //⦁	Has Issues collection – an Issue type
    }
}
