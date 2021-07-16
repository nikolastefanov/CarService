using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarService.Data.Models
{
    public class IssueType
    {

        public IssueType()
        {
            this.Issues = new HashSet<Issue>();
            this.SpareParts = new HashSet<SparePart>();
        }
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public string ImageUrl { get; set; }

        public IEnumerable<Issue> Issues { get; set; }

        public IEnumerable<SparePart> SpareParts { get; set; }
    }
}
