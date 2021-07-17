
namespace CarService.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

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

        public string UserId { get; set; }

        public User User { get; set; }


    }
}
