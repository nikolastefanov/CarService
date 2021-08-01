
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
                };
            
                this.data.Issues.Add(issueData);
                this.data.SaveChanges();
        }

        public CarIssuesServiceModel GetAllIssues(int carId)
        {

            var carData = this.data
                .Cars
                .Where(x => x.Id == carId)
                .Select(x => new CarIssuesServiceModel
                {
                    Id = x.Id,
                    Make = x.Make,
                    Model = x.Model,
                    PlateNumber = x.PlateNumber,
                    Year = x.Year,
                    Issues = x.Issues
                             .Select(i => new IssueServiceModel
                             {
                                 Id=i.Id,
                                 Description=i.Description,
                                 CarId=i.CarId,
                             })
                }).FirstOrDefault();              

            return carData;
        }
    }
}
