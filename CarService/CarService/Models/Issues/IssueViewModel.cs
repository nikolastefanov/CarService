﻿
namespace CarService.Models.Issues
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;


    public class IssueViewModel
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public int CarId { get; set; }
    }
}
