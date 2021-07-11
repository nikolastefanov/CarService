using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarService.Data.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }
        
        public int Year { get; set; }
        
        public string ImageUrl { get; set; }
        
        public ICollection<Issue> Issues { get; set; }


        //⦁	Has a PlateNumber – a string – Must be a valid Plate number(2 Capital English letters, followed by 4 digits, followed by 2 Capital English letters (required)
        //⦁	Has a OwnerId – a string (required)
        //⦁	Has a Owner – a User object
        //⦁	Has Issues collection – an Issue type
    }
}
