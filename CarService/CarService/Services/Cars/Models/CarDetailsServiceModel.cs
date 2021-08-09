using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarService.Services.Cars
{
    public class CarDetailsServiceModel
    {
        public int Id { get; init; }

        public string Make { get; init; }

        public string Model { get; init; }

        public string PlateNumber { get; set; }

        public string ImageUrl { get; set; }

        public int Year { get; init; }

        public int IssueTypeId { get; set; }

    }
}
