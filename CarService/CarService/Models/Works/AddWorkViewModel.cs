
namespace CarService.Models.Works
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    using  static Data.DataConstants.Work;

    public class AddWorkViewModel
    {
        public int IssueId { get; set; }

        [Required]
        [StringLength(WorkMaxLength, MinimumLength = WorkMinLength)]
        public string Description { get; set; }

        [Range((double)WorkMinPrice,(double)WorkMaxPrice)]
        public decimal Price { get; set; }

        public int CarId { get; set; }

    }
}
