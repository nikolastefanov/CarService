
namespace CarService.Models.Issues
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    using static Data.DataConstants.Issue;

    public class EditIssueViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(DescripMaxLength, MinimumLength = DescripMinLength)]
        public string Description { get; set; }

        public bool IsFixed { get; set; }

        public int CarId { get; set; }

    }
}
