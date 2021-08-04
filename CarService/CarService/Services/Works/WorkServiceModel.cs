
namespace CarService.Services.Works
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class WorkServiceModel
    {
        public int Id { get; set; }

        public int IssueId { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }
    }
}
