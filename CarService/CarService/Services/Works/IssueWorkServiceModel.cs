
namespace CarService.Services.Works
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class IssueWorkServiceModel
    {

        public int Id { get; set; }

        public string Description { get; set; }

        public bool IsFixed { get; set; }

        public int CarId { get; set; }

        public IEnumerable<WorkServiceModel> Works { get; set; }
    }
}
