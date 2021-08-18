
namespace CarService.Services.Issues
{
    using CarService.Data;
    using CarService.Data.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class IssuesService : IIssuesService
    {
        private readonly ApplicationDbContext data;

        public IssuesService(ApplicationDbContext data)
        {
            this.data = data;
        }

        public void AddIssueToCar(string description, int carId)
        {
            var issueData = new Issue
                {
                    Description=description,
                    CarId=carId,
                    IsFixed=false,
                    IsDelete=false,
                };
            
                this.data.Issues.Add(issueData);
                this.data.SaveChanges();
        }

        public void DeleteToIssue(int issueId, int carId)
        {
            var issue = this.data
                .Issues
                .Where(x => x.CarId == carId && x.Id==issueId && x.IsDelete==false)
                .FirstOrDefault();

            issue.IsDelete = true;

            this.data.SaveChanges();
        }

        public IssueServiceModel DetailsIssue(int issueId, int carId)
        {
            var issueData = this.data
               .Cars
               .Where(x => x.Id == carId && x.IsDelete==false)
               .Select(x => x.Issues
                            .Where(s => s.Id == issueId && s.IsDelete==false)
                            .Select(i => new IssueServiceModel
                            {
                                Id = i.Id,
                                Description = i.Description,
                                IsFixed=i.IsFixed,
                                CarId = i.CarId,
                            }).FirstOrDefault()
               ).FirstOrDefault();

            return issueData;

        }

        public void EditIssue(int issueId, int carId, string description,bool isfixed)
        {
            var issueData = this.data
                .Issues
                .Where(x => x.CarId == carId && x.Id == issueId && x.IsDelete==false)
                .FirstOrDefault();


            issueData.Description = description;
            issueData.IsFixed = isfixed;
            ;

            this.data.SaveChanges();
        }

        public void FixIssue(int issueId, int carId)
        {
            var issue = this.data
              .Issues
              .Where(x => x.IsDelete == false)
              .FirstOrDefault(x=>x.Id==issueId);
            
              issue.IsFixed = true;
            
              this.data.SaveChanges();
        }

        public IEnumerable<CarIssueServiceModel> GetAllIssues(int carId)
        {

            var carData = this.data
               .Cars
               .Where(x => x.Id == carId && x.IsDelete==false)
               .Select(x => new CarIssueServiceModel
               {
                   Id = x.Id,
                   Make = x.Make,
                   Model = x.Model,
                   PlateNumber = x.PlateNumber,
                   Year = x.Year,
                   Issues = x.Issues
                            .Where(i=>i.IsDelete==false)
                            .Select(i => new IssueServiceModel
                            {
                                Id = i.Id,
                                Description = i.Description,
                                CarId = i.CarId,
                                IsFixed=i.IsFixed,
                            }).ToList()
               }).ToList();

        

            return carData;
        }
    }
}
