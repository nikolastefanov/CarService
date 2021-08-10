
namespace CarService.Models.Cars
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class CarAdminViewModel
    {
        public int Id { get; init; }

        public string Make { get; init; }

        public string Model { get; init; }

        public string PlateNumber { get; set; }

        public string ImageUrl { get; init; }

        public int Year { get; init; }

        public string IssueTypeName { get; init; }

    }
}
