
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
        public int CreateWork(string userId,int issueId,string description, decimal price,int carId)
        {
            var workData = new Works
            {
                IssueId=issueId,
                Description=description,
                Price=price,
                IsDelete=false,
            };


            this.data.Works.Add(workData);

            this.data.SaveChanges();

            int workId = workData.Id;
            
            return workId;
        }

        public void DeleteToWork(int workId, int issueId,int carId)
        {
            var work = this.data
             .Issues
             .Where(x => x.Id == issueId && x.CarId == carId && x.IsDelete==false)
             .Select(s => s.Works
                         .Where(s => s.Id == workId && s.IsDelete==false).FirstOrDefault()
            ).FirstOrDefault();

            ;
            work.IsDelete = true;

            var workDelete = this.data
             .Issues
             .Where(x => x.Id == issueId && x.CarId == carId )
             .Select(s => s.Works
                         .Where(s => s.Id == workId && s.IsDelete == false).FirstOrDefault()
            ).FirstOrDefault();

            ;

            this.data.SaveChanges();

        }

        public WorkServiceModel DetailsWork(int workId, int issueId, int carId)
        {
            var work = this.data
             .Issues
             .Where(x => x.Id == issueId && x.CarId == carId && x.IsDelete==false)
             .Select(s => s.Works
                         .Where(x => x.Id == workId && x.IsDelete==false)
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
             .Where(x => x.Id == issueId && x.CarId == carId && x.IsDelete==false)
             .Select(s => s.Works
                          .Where(x => x.Id == workId && x.IsDelete==false).FirstOrDefault()                   
            ).FirstOrDefault();

            if (workData==null)
            {
                return false;
            }
         
             workData.Description = description;
             workData.Price = price;

            this.data.SaveChanges();

            //Za proverka sled SaveChanges !!!

       //  var workData1 = this.data
       //   .Issues
       //   .Where(x => x.Id == issueId && x.CarId == carId && x.IsDelete==false)
       //  .Select(s => s.Works
       //              .Where(x => x.Id == workId && x.IsDelete==false)
       //              .Select(w => new WorkServiceModel
       //              {
       //                  Id = w.Id,
       //                  Description = w.Description,
       //                  IssueId = w.IssueId,
       //                  Price = w.Price,
       //              }).FirstOrDefault()
       // 
       // ).FirstOrDefault();            

            return true;
        }



        public IEnumerable<IssueWorkServiceModel> GetAllWorks(int issueId,int carId)
        {
            var allWorks = this.data
              .Issues
              .Where(x => x.Id == issueId && x.CarId == carId && x.IsDelete==false)
             .Select(s => new IssueWorkServiceModel
             {
                 Id = s.Id,
                 Description = s.Description,
                 IsFixed = s.IsFixed,
                 CarId = s.CarId,
                 Works = s.Works
                          .Where(x=>x.IsDelete==false)
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
        public string GetUserId(int carId)
        {
            var carData = this.data
                .Cars
                .Where(x => x.IsDelete == false)
               .FirstOrDefault(x => x.Id == carId);


            return carData.UserId;
        }
    }
}
