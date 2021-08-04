
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
        public bool CreateWork(int issueId,string description, decimal price)
        {
            var workData = new Work
            {
                IssueId=issueId,
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

        public IEnumerable<WorkServiceModel> GetAllWorks(int issueId,int carId)
        {
            var allWorks = this.data
              .Issues
              .Where(x => x.CarId == carId && x.Id == issueId)
              .FirstOrDefault();

            var listWorks = allWorks
              .Works
              .Select(x => new WorkServiceModel
              {
                  Id = x.Id,
                  Description = x.Description,
                  IssueId = x.IssueId,
                  Price = x.Price,
              }).ToList();


            return listWorks;
        }  
        
    }
}
