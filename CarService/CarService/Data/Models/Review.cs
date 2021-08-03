
namespace CarService.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    using static Data.DataConstants.Review;

    public class Review
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(ContentMaxLength)]
        public string Content { get; set; }

        public DateTime CreateOn { get; set; }

        public string UserId { get; set; }

        public User User { get; set; }
    }
}
