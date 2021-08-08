
namespace CarService.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using static Data.DataConstants.Work;


    public class Works
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(WorkMaxLength)]
        public string Description{ get; set; }

        public decimal Price { get; set; }

        public string OrderId { get; set; }

        public Order Order { get; set; }

        public int IssueId { get; set; }

        public Issue Issue { get; set; }


    }
}
