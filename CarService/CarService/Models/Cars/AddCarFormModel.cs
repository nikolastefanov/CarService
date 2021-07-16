
namespace CarService.Models.Cars
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    using static Data.DataConstants;


    public class AddCarFormModel
    {

        [Required]
        [StringLength(CarBrandMaxLength, MinimumLength = CarBrandMinLength)]
        public string Make { get; init; }

        [Required]
        [StringLength(CarModelMaxLength, MinimumLength = CarModelMinLength)]
        public string Model { get; init; }

        [Required]
        [StringLength(CarNumberMaxLength, MinimumLength = CarNumberMinLength)]
        public string PlateNumber { get; set; }

        [Display(Name = "Image URL")]
        [Required]
        [Url]
        public string ImageUrl { get; init; }

        [Range(CarYearMinValue, CarYearMaxValue)]
        public int Year { get; init; }

        [Required]
        [StringLength(CarIssueTypeMaxLength, MinimumLength = CarIssueTypeMinLength)]
        public string IssueType { get; set; }

        [Required]
        [StringLength(CarIssueMaxLength, MinimumLength = CarIssueMinLength)]
        public string Issue { get; set; }
    }
}
