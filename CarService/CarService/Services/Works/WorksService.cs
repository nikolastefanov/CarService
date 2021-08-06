
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

        public void DeleteToWork(int workId, int issueId,int carId)
        {
            var work = this.data
             .Issues
             .Where(x => x.Id == issueId && x.CarId == carId)
             .Select(s => s.Works
                         .Where(s => s.Id == workId).FirstOrDefault()
            ).FirstOrDefault();

            this.data.Works.Remove(work);

            this.data.SaveChanges();

        }

        public WorkServiceModel DetailsWork(int workId, int issueId, int carId)
        {
            var work = this.data
             .Issues
             .Where(x => x.Id == issueId && x.CarId == carId)
             .Select(s => s.Works
                         .Where(x => x.Id == workId)
                         .Select(w=>new WorkServiceModel
                         {
                             Id = w.Id,
                             Description = w.Description,
                             IssueId = w.IssueId,
                             Price = w.Price,
                         })
                         .FirstOrDefault()
            ).FirstOrDefault();
            

            return work;
      
        }

        public bool EditToWork(int workId, int issueId, int carId
                    ,string description,decimal price)
        {
            
            var workData = this.data
             .Issues
             .Where(x => x.Id == issueId && x.CarId == carId)
             .Select(s => s.Works
                          .Where(x => x.Id == workId).FirstOrDefault()
                       // .Select(w => new WorkServiceModel
                       // {
                       //     Id = w.Id,
                       //     Description = w.Description,
                       //     IssueId = w.IssueId,
                       //     Price = w.Price,
                       // }).FirstOrDefault()
   
            ).FirstOrDefault();

            //TODO: poverka dali ima work
         

             workData.Description = description;
             workData.Price = price;



            this.data.SaveChanges();

           var workData1 = this.data
            .Issues
            .Where(x => x.Id == issueId && x.CarId == carId)
           .Select(s => s.Works
                       .Where(x => x.Id == workId)
                       .Select(w => new WorkServiceModel
                       {
                           Id = w.Id,
                           Description = w.Description,
                           IssueId = w.IssueId,
                           Price = w.Price,
                       }).FirstOrDefault()
          
          ).FirstOrDefault();
            ;

            return true;

        }



        public IEnumerable<IssueWorkServiceModel> GetAllWorks(int issueId,int carId)
        {
            var allWorks = this.data
              .Issues
              .Where(x => x.Id == issueId && x.CarId == carId)
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

            return allWorks;
         
        }  
        
    }
}
