﻿

namespace CarService.Areas.Admin.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class OrderViewModel
    {
        public string Id { get; set; }

        public string UserId { get; set; }

        public decimal TotalPrice { get; set; }

        public DateTime CreateOn { get; set; }

    }
}
