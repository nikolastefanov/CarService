using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarService.Models.Issues
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class CarIssuesViewModel
    {
     

        public int Id { get; set; }

        public string PlateNumber { get; set; }

        public string Make { get; set; }

        public string ModelCar { get; set; }

        public int Year { get; set; }

        public IEnumerable<IssueViewModel> Issues { get; set; }

    }
}
