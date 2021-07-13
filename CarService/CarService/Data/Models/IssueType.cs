using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarService.Data.Models
{
    public class IssueType
    {

        public IssueType()
        {
            this.Issues = new HashSet<Issue>();
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Issue> Issues { get; set; }
    }
}
