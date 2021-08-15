
namespace CarService.Models.Works
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class ListingWorkViewModel 
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public bool IsFixed { get; set; }

        public int CarId { get; set; }

        public IEnumerable<WorkWorkViewModel> Works { get; set; }
    }
}
