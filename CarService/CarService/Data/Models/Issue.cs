﻿
namespace CarService.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    using static Data.DataConstants.Issue;

    public class Issue
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(DescripMaxLength)]
        public string Description { get; set; }

        public int CarId {get;set;}

        public Car Car { get; set; }

        public int IssueTypeId { get; set; }

        public IssueType IssueType { get; set; }

    }
}
