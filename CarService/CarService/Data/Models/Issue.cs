
namespace CarService.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class Issue
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public int CarId {get;set;}

        public Car Car { get; set; }

        public int WorkId { get; set; }

        public Work Work { get; set; }


        //⦁	Has a IsFixed – a bool indicating if the issue has been fixed or not (required)
       

    }
}
