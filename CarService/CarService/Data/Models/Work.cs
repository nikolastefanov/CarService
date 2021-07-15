
namespace CarService.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;


    public class Work
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Description{ get; set; }

        public decimal PriceWork { get; set; }

        public string OrderId { get; set; }

        public Order Order { get; set; }


    }
}
