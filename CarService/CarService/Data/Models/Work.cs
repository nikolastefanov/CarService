
namespace CarService.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using static Data.DataConstants.Work;


    public class Work
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(DescripMaxLength)]
        public string Description{ get; set; }

        public decimal PriceWork { get; set; }

        public string OrderId { get; set; }

        public Order Order { get; set; }

        public string MechanicId { get; set; }

        public Mechanic Mechanic { get; set; }


    }
}
