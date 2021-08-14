using Ganss.XSS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarService.Models.Reviews
{
    public class ReviewViewModel
    {
        public int Id { get; set; }

        public string SanContent { get; set; }

        public string CreateOn { get; set; }

        public int CurrentPage { get; set; }

        public int PagesCount { get; set; }


        // public string UserId { get; set; }
    }
}
