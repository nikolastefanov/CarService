using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarService.Services.Cars
{
    public class AddCarServiceModel
    {
      
        public string UserId { get; set; }

        public string Make { get; init; }

        public string Model { get; init; }
       
        public string PlateNumber { get; set; }

        public string ImageUrl { get; init; }

        public int Year { get; init; }

        public int IssueTypeId { get; set; }

    }
}
