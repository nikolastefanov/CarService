﻿
namespace CarService.Models.Works
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    using  static Data.DataConstants.Work;

    public class AddWorkViewModel
    {

        [Required]
        [StringLength(WorkMaxLength, MinimumLength = WorkMinLength)]
        public string Description { get; set; }

        public decimal Price { get; set; }

    }
}
