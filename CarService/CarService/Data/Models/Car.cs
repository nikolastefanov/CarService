
namespace CarService.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    public class Car
    {

        public Car()
        {
            this.Issues = new HashSet<Issue>();
            this.Orders = new HashSet<Order>();
        }
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Model { get; set; }

        [Required]
        [MaxLength(20)]
        public string PlateNumber { get; set; }
        
        public int Year { get; set; }
        
        [Required]
        public string ImageUrl { get; set; }


        public string UserId { get; set; }

        public User User { get; set; }
        
        public IEnumerable<Issue> Issues { get; set; }

        public IEnumerable<Order> Orders { get; set; }


        
      
    }
}
