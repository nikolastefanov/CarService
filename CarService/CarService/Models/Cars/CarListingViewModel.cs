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

        public string PlateNumber { get; set; }

        public string ImageUrl { get; init; }

        public int Year { get; init; }

        public int IssueTypeId { get; set; }

        public string IssueType { get; set; }

        public int RemainingIssues { get; init; }

        public int FixedIssues { get; init; }
    }
}
