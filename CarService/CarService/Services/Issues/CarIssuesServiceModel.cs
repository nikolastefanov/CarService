
namespace CarService.Services.Issues
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class IssuesServiceModel
    {

        public int Id { get; set; }

        public string PlateNumber { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

      //  public IEnumerable<IssueServiceModel> Issues { get; set; }

    }
}
