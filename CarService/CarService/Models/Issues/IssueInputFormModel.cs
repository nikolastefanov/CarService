
namespace CarService.Models.Issues
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;


    public class IssueInputFormModel
    {
        public int IssueTypeId { get; set; }

        public string Description { get; set; }

        public int CarId { get; set; }

        public IEnumerable<IssueTypeViewModel> IssueTypes { get; set; }

    }
}