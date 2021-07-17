
namespace CarService.Models.Cars
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    using static Data.DataConstants.Car;
    using static Data.DataConstants.IssueType;
    using static Data.DataConstants.Issue;




    public class AddCarFormModel
    {

        [Required]
        [StringLength(MakeMaxLength, MinimumLength = MakeMinLength)]
        public string Make { get; init; }

        [Required]
        [StringLength(ModelMaxLength, MinimumLength = ModelMinLength)]
        public string Model { get; init; }

        [Required]
        [StringLength(PlateNumberMaxLength, MinimumLength = PlateNumberMinLength)]
        public string PlateNumber { get; set; }

        [Display(Name = "Image URL")]
        [Required]
        [Url]
        public string ImageUrl { get; init; }

        [Range(YearMinValue, YearMaxValue)]
        public int Year { get; init; }

        [Required]
        [StringLength(IsTypeNameMaxLength, MinimumLength = IsTypeNameMinLength)]
        public string IssueType { get; set; }

        [Required]
        [StringLength(InpMaxLength, MinimumLength = InpMinLength)]
        public string Issue { get; set; }
    }
}
