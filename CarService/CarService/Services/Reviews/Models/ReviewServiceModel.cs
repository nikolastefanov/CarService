
namespace CarService.Services.Reviews
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class ReviewServiceModel
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public DateTime CreateOn { get; set; }

         public string UserId { get; set; }
    }
}
