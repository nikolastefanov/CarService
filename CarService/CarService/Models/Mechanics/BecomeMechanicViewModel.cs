
namespace CarService.Models.Mechanics
{
    using System.ComponentModel.DataAnnotations;

    using static Data.DataConstants.Mechanic;

    public class BecomeMechanicViewModel
    {

        [Required]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
        public string FullName { get; set; }
       
       // [Required]
       // [StringLength(PhoneNumberMaxLength, MinimumLength = PhoneNumberMinLength)]
       // [Display(Name = "Phone Number")]
       // public string PhoneNumber { get; set; }

    }
}
