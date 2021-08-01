

namespace CarService.Controllers
{
    using CarService.Data;
    using CarService.Data.Models;
    using CarService.Models.Issues;
    using CarService.Services.Issues;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;


    public class IssuesController : Controller
    {
        private readonly IIssuesService issuesService;

        public IssuesController(IIssuesService issuesService)
        {
            this.issuesService = issuesService;
        }

            public IActionResult AddIssue()
            {
                return this.View();
            }
           
          [HttpPost]
          public IActionResult AddIssue(AddIssueViewModel issue, int carId)
          {
            //   if (!this.data.IssueTypes.Any(c => c.Id == issue.IssueTypeId))
            //   {
            //       this.ModelState.AddModelError(nameof(issue.IssueTypeId), "IssueType does not exist.");
            //   }
            //  
            //   if (!ModelState.IsValid)
            //   {
            //       issue.IssueTypes = this.GetIssueTypes();
            //  
            //       return View(issue);
            //   }
            //  
            //    var issueData = new Issue
            //    {
            //        Description=issue.Description,
            //        IssueTypeId=issue.IssueTypeId,
            //        CarId=carId,
            //    };
            //
            //    this.data.Issues.Add(issueData);
            //    this.data.SaveChanges();


            //issue.CarId = carId;

            this.issuesService.AddIssueToCar(
                issue.Description
                , issue.CarId);

          
              return RedirectToAction("All");
          
            }

          
        public IActionResult AllIssues(int carId)
        {

            var carData = this.issuesService
                .GetAllIssues(carId);

            var carIssuesData = new CarIssuesViewModel
            {
                Id = carData.Id,
                Make = carData.Make,
                ModelCar = carData.Model,
                Year = carData.Year,
                PlateNumber = carData.PlateNumber,
               Issues=carData.Issues.Select(i=>new IssueViewModel
                                        {
                                          Id=i.Id,
                                          Description=i.Description,
                                          CarId=i.CarId,
                                        }),
            };

            return this.View(carIssuesData);
        }
    }
}
