using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarService.Models.Cars
{
    public class CarListingViewModel
    {
        public int Id { get; init; }

        public string Make { get; init; }

        public string Model { get; init; }

        public string ImageUrl { get; init; }

        public int Year { get; init; }

        public string IssueType { get; set; }

        public string Issue { get; set; }
    }
}
