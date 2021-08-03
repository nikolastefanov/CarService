using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarService.Models.Reviews
{
    public class ReviewViewModel
    {
        public int Id { get; set; }
        public string Content { get; set; }

        public string CreateOn { get; set; }

       // public string UserId { get; set; }
    }
}
