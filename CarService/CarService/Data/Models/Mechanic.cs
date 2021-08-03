
namespace CarService.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    using static Data.DataConstants.Mechanic;

    public class Mechanic
    { 
        public int Id { get; init; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string FullName { get; set; }

        [Required]
        [MaxLength(PhoneNumberMaxLength)]
        public string PhoneNumber { get; set; }

        [Required]
        public string UserId { get; set; }
     
    }
}
