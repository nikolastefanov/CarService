
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
    using CarService.Models.IssueTypes;

    using static Data.DataConstants.Car;

    public class AddCarFormModel
    {

        [Required]
        [StringLength(MakeMaxLength, MinimumLength = MakeMinLength)]
        public string Make { get; init; }

        [Required]
        [StringLength(ModelMaxLength, MinimumLength = ModelMinLength)]
        public string Model { get; init; }     


        [Required]
        [RegularExpression("CarRegexPlateNumber")]
        public string PlateNumber { get; set; }

        [Display(Name = "Image URL")]
        [Required]
        [Url]
        public string ImageUrl { get; init; }

        [Range(YearMinValue, YearMaxValue)]
        public int Year { get; init; }       

        public int IssueTypeId { get; set; }

        public IEnumerable<IndexIssueTypeViewModel> IssueTypes { get; set; }
        
           
    }
}
