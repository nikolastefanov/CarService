﻿
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
                };
            
                this.data.Issues.Add(issueData);
                this.data.SaveChanges();
        }

        public void DeleteToIssue(int issueId, int carId)
        {
            var issue = this.data
                .Issues
                .Where(x => x.CarId == carId && x.Id==issueId)
                .FirstOrDefault();

            this.data.Issues.Remove(issue);

            this.data.SaveChanges();
        }

        public IEnumerable<CarIssueServiceModel> DetailsIssue(int issueId, int carId)
        {
            var carData = this.data
               .Cars
               .Where(x => x.Id == carId)
               .Select(x => new CarIssueServiceModel
               {
                   Id = x.Id,
                   Make = x.Make,
                   Model = x.Model,
                   PlateNumber = x.PlateNumber,
                   Year = x.Year,
                   Issues = x.Issues
                            .Where(s=>s.Id==issueId)
                            .Select(i => new IssueServiceModel
                            {
                                Id = i.Id,
                                Description = i.Description,
                                CarId = i.CarId,
                            }).ToList()
               }).ToList();

            return carData;


            // var carData = this.data
            //    .Cars
            //    .Where(x => x.Id == carId)
            //    .Select(x => new CarIssuesServiceModel
            //    {
            //        Id = x.Id,
            //        Make = x.Make,
            //        Model = x.Model,
            //        PlateNumber = x.PlateNumber,
            //        Year = x.Year,
            //       // Issues = x.Issues
            //       //          .Where(i=>i.Id==issueId)
            //       //          .Select(i => new IssueServiceModel
            //       //          {
            //       //              Id = i.Id,
            //       //              Description = i.Description,
            //       //              CarId = i.CarId,
            //       //          })
            //    }).FirstOrDefault();



          //  return null; // carData;
        }

        public void EditIssue(int issueId, int carId, string description)
        {
            var issueData = this.data
                .Issues
                .Where(x => x.CarId == carId && x.Id == issueId)
                .FirstOrDefault();


            issueData.Description = description;

            this.data.SaveChanges();
        }

        public IEnumerable<CarIssueServiceModel> GetAllIssues(int carId)
        {

            var carData = this.data
               .Cars
               .Where(x => x.Id == carId)
               .Select(x => new CarIssueServiceModel
               {
                   Id = x.Id,
                   Make = x.Make,
                   Model = x.Model,
                   PlateNumber = x.PlateNumber,
                   Year = x.Year,
                   Issues = x.Issues
                            .Select(i => new IssueServiceModel
                            {
                                Id = i.Id,
                                Description = i.Description,
                                CarId = i.CarId,
                            }).ToList()
               }).ToList();

        

            return carData;
        }
    }
}
