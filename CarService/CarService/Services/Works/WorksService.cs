

namespace CarService.Services.Works
{
    using CarService.Data;
    using CarService.Data.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;


    public class WorksService : IWorksService
    {
        private readonly ApplicationDbContext data;

        public WorksService(ApplicationDbContext data)
        {
            this.data = data;
        }
        public bool CreateWork(string description, decimal price)
        {
            var workData = new Work
            {
                Description=description,
                Price=price,
            };

            if (workData==null)
            {
                return false;
            }

            this.data.Works.Add(workData);

            this.data.SaveChanges();

            return true;
        }
    }
}
