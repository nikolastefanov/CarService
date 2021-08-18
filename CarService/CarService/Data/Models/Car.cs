
namespace CarService.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    using static Data.DataConstants.Car;

    public class Car
    {
        public Car()
        {
            this.Issues = new HashSet<Issue>();
        }
        public int Id { get; set; }

        [Required]
        [MaxLength(MakeMaxLength)]
        public string Make { get; set; }

        [Required]
        [MaxLength(ModelMaxLength)]
        public string Model { get; set; }

        [Required]
        [RegularExpression("CarRegexPlateNumber")]
        public string PlateNumber { get; set; }
        
        [Range(YearMinValue,YearMaxValue)]
        public int Year { get; set; }
        
        [Required]
        public string ImageUrl { get; set; }

        public bool IsDelete { get; set; }


        public string UserId { get; set; }

        public User User { get; set; }

        public int IssueTypeId { get; set; }

        public IssueType IssueType { get; set; }

      public  IEnumerable<Issue> Issues { get; set; }

      
    }
}
