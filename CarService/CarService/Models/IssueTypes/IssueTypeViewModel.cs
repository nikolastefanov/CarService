
namespace CarService.Models.IssueTypes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    using static Data.DataConstants.IssueType;


    public class IssueTypeViewModel
    {

        [Required]
        [StringLength(IssueTypeMaxLength, MinimumLength = IssueTypeMinLength)]
        public string Name { get; set; }

        [Required]
        [Url]
        public string ImageUrl { get; set; }
    }
}
