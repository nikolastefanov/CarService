
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
              .Select(s => new IssueWorkServiceModel
              {
                  Id = s.Id,
                  Description = s.Description,
                  IsFixed = s.IsFixed,
                  CarId = s.CarId,
                  Works = s.Works
                           .Select(w => new WorkServiceModel
                           {
                               Id = w.Id,
                               Description = w.Description,
                               IssueId = w.IssueId,
                               Price = w.Price,
                           }).ToList()
              }).ToList();

            return null;


         

          //  var carData = this.data
          //     .Cars
          //     .Where(x => x.Id == carId)
          //     .Select(x => new CarIssueServiceModel
          //     {
          //         Id = x.Id,
          //         Make = x.Make,
          //         Model = x.Model,
          //         PlateNumber = x.PlateNumber,
          //         Year = x.Year,
          //         Issues = x.Issues
          //                  .Select(i => new IssueServiceModel
          //                  {
          //                      Id = i.Id,
          //                      Description = i.Description,
          //                      CarId = i.CarId,
          //                  }).ToList()
          //     }).ToList();


            //  var listWorks = allIssues
            //    .Works
            //    .Select(x => new WorkServiceModel
            //    {
            //        Id = x.Id,
            //        Description = x.Description,
            //        IssueId = x.IssueId,
            //        Price = x.Price,
            //    }).ToList();
            //


        }  
        
    }
}
