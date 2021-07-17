
namespace CarService.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    using static Data.DataConstants.SparePart;

    public class SparePart
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; }

        [Required]
        [MaxLength(ManufactorerMaxLength)]
        public string Manufacturer { get; set; }

        public string ImageUrl{get;set;}

        public decimal Price { get; set; }

        public int Available { get; set; }

        public string OrderId { get; set; }

        public Order Order { get; set; }

        public int IssueTypeId { get; set; }

        public IssueType IssueType { get; set; }
    }
}
