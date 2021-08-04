

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
        

            issue.CarId = carId;

            this.issuesService.AddIssueToCar(
                issue.Description
                , issue.CarId);

            return Redirect($"/Issues/AllIssues?carId={carId}");

        }


        public IActionResult AllIssues(int carId)
        {

            var carData =issuesService
                .GetAllIssues(carId)
                .Select(x => new CarIssuesViewModel
                {
                    Id = x.Id,
                    Make = x.Make,
                    ModelCar = x.Model,
                    Year = x.Year,
                    PlateNumber = x.PlateNumber,
                    Issues = x.Issues.Select(i => new IssueViewModel
                    {
                        Id = i.Id,
                        Description = i.Description,
                        CarId = i.CarId,
                        IsFixed = i.IsFixed,
                    }).ToList(),

                })
                .FirstOrDefault();          

            return this.View(carData);
            
        }


         public IActionResult EditIssue(int issueId,int carId)
         {

            var issueEdit = issuesService.DetailsIssue(issueId, carId);


            return this.View();


         //    .Select(x => new CarIssuesViewModel
         //    {
         //        Id = x.Id,
         //        Make = x.Make,
         //        ModelCar = x.Model,
         //        Year = x.Year,
         //        PlateNumber = x.PlateNumber,
         //        Issues = x.Issues
         //                 .Where(s => s.Id == issueId)
         //                 .Select(i => new IssueViewModel
         //                 {
         //                     Id = i.Id,
         //                     Description = i.Description,
         //                     CarId = i.CarId,
         //                     IsFixed = i.IsFixed,
         //                 }).ToList(),
         //
         //    })
         //    .FirstOrDefault();
         //
         // return this.View(carData);

         //   var carEdit = this.carsService.CarDetails(carId);
         //
         //
         //   var issueTypes = this.carsService
         //           .AllIssueTypes()
         //           .Select(x => new IndexIssueTypeViewModel
         //           {
         //               Id = x.Id,
         //               Name = x.Name,
         //               ImageUrl = x.ImageUrl,
         //           }).ToList();
         //
         //
         //   return this.View(new EditCarViewModel
         //   {
         //       Id = carEdit.Id,
         //       Make = carEdit.Make,
         //       Model = carEdit.Model,
         //       PlateNumber = carEdit.PlateNumber,
         //       ImageUrl = carEdit.ImageUrl,
         //       Year = carEdit.Year,
         //       IssueTypeId = carEdit.IssueTypeId,
         //       IssueTypes = issueTypes,
         //   });

        }

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
