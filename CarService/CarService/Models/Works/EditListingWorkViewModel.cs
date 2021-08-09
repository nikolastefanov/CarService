
namespace CarService.Models.Works
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    using static Data.DataConstants.Work;

    public class EditListingWorkViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(WorkMaxLength, MinimumLength = WorkMinLength)]
        public string Description { get; set; }

        public bool IsFixed { get; set; }

        public int CarId { get; set; }

        public IEnumerable<WorkWorkViewModel> Works { get; set; }
    }
}
