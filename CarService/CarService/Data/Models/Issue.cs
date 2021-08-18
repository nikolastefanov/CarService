
namespace CarService.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    using static Data.DataConstants.Issue;

    public class Issue
    {
        public Issue()
        {
            this.Works = new HashSet<Works>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(DescripMaxLength)]
        public string Description { get; set; }

        [Required]
        public bool IsFixed { get; set; }

        public bool IsDelete { get; set; }

        [Required]
        public int CarId {get;set;}

        public Car Car { get; set; }

        public IEnumerable<Works> Works { get; set; }
    }
}
