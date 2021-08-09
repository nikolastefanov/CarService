using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarService.Services.Cars
{
    public class CarIssueTypeServiceModel
    {
        public int Id { get; init; }

        public string Name { get; init; }

        public string ImageUrl { get; set; }
    }
}
