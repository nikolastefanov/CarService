

namespace CarService.Models.Cars
{
    using CarService.Models.IssueTypes;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    using static CarService.Data.DataConstants.Car;

    public class EditCarViewModel
    {
        public int Id { get; set; }

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

        public int IssueTypeId { get; set; }

        public IEnumerable<IndexIssueTypeViewModel> IssueTypes { get; set; }
    }
}
