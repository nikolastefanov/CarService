

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

        public IActionResult AddIssue(int carId)
        {
            return this.View(new AddIssueViewModel
            {
                CarId = carId
            });
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


            issue.CarId = carId;

            this.issuesService.AddIssueToCar(
                issue.Description
                , issue.CarId);


            return RedirectToAction("AllIssues");

        }


        public IActionResult AllIssues(int carId)
        {

            var carData = this.issuesService
                .GetAllIssues(carId);

            //CarIssuesViewModel carIssuesData = new CarIssuesViewModel
            //{
            //    Id = carData.Id,
            //    Make = carData.Make,
            //    ModelCar = carData.Model,
            //    Year = carData.Year,
            //    PlateNumber = carData.PlateNumber,
            //  //  Issues = carData.Issues.Select(i => new IssueViewModel
            //  //  {
            //  //      Id = i.Id,
            //  //      Description = i.Description,
            //  //      CarId = i.CarId,
            //  //  }).ToList()
            //};

            var carIssuesData = carData
                .Select(x => new IssueViewModel
                {
                    Id = x.Id,
                    Description = x.Description,
                    IsFixed=x.IsFixed,
                    CarId = x.CarId,
                }).ToList();
                




            return this.View(carIssuesData);
        }


     //  public IActionResult EditIssue(int issueId,int carId)
     //  {
     //      var carData=this.issuesService.DetailsIssue(issueId, carId);
     //      var carIssueData = new CarIssuesViewModel
     //      {
     //          Id = carData.Id,
     //          Make = carData.Make,
     //          ModelCar = carData.Model,
     //          Year = carData.Year,
     //          PlateNumber = carData.PlateNumber,
     //          Issues = carData.Issues
     //          .Where(i=>i.Id==issueId)
     //          .Select(i => new IssueViewModel
     //          {
     //              Id = i.Id,
     //              Description = i.Description,
     //              CarId = i.CarId,
     //          })
     //      };
     //      return this.View(carIssueData);
     //  }

        [HttpPost]
        public IActionResult EditIssue(int issueId,int carId, EditCarIssueViewModel issuesModel)
        {
            // public IActionResult Edit(int carId)
            // {
            //     var carEdit = this.carsService.EditCar(
            //                      carId
            //                      , car.Make
            //                      , car.Model
            //                      , car.PlateNumber
            //                      , car.ImageUrl
            //                      , car.Year
            //                      , car.IssueTypeId);
            //
            //     if (!carEdit)

             this.issuesService.EditIssue(
                                          issueId
                                          , carId
                                          , issuesModel.Description);

                    return this.View("AllIssues");
        }

        public IActionResult DeleteIssue(int issueId, int carId)
        {

            this.issuesService.DeleteToIssue(issueId, carId);

            return Redirect($"/Issues/AllIssues?carId={carId}");
        }
    }
}
