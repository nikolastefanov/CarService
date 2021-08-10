
namespace CarService.Models.Reviews
{
    using Ganss.XSS;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    using static Data.DataConstants.Review;


    public class ReviewInputFormModel
    {
        [Required]
        [StringLength(ContentMaxLength, MinimumLength = ContentMinLength)]
        public string Content { get; set; }

        // public string UserId { get; set; }
    }
}
