
namespace CarService.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    using static Data.DataConstants.IssueType;

    public class IssueType
    {

        public IssueType()
        {
            this.Cars = new HashSet<Car>();
        }
        
        public int Id { get; set; }

        [Required]
        [MaxLength(IsTypeNameMaxLength)]
        public string Name { get; set; }

        public string ImageUrl { get; set; }

     
        public IEnumerable<Car> Cars { get; set; }
    }
}
