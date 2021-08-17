

namespace CarService.Controllers
{
    using CarService.Data;
    using CarService.Data.Models;
    using CarService.Models.Issues;
    using CarService.Services.Issues;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using static WebConstants;

    public class IssuesController : Controller
    {
        private readonly IIssuesService issuesService;

        public IssuesController(IIssuesService issuesService)
        {
            this.issuesService = issuesService;
        }


        [Authorize]
        public IActionResult AddIssue(int carId)
        {
            return this.View(new AddIssueViewModel
            {
                CarId = carId
            });
        }

        [Authorize]
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


        [Authorize]
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

        [Authorize(Roles = AdministratorRoleName)]
         public IActionResult EditIssue(int issueId,int carId)
         {

            var issueEdit = issuesService.DetailsIssue(issueId, carId);


            return this.View(new IssueViewModel
            {
                Id=issueEdit.Id,
                Description=issueEdit.Description,
                IsFixed=issueEdit.IsFixed,
                CarId = issueEdit.CarId,
            });

        }

        [Authorize(Roles = AdministratorRoleName)]
        [HttpPost]
        public IActionResult EditIssue(int issueId,int carId,IssueViewModel  issuesModel)
        {
     

             this.issuesService.EditIssue(
                                          issueId
                                          , carId
                                          , issuesModel.Description
                                          ,issuesModel.IsFixed);

                    return Redirect($"/Issues/AllIssues?carId={carId}");
        }


        [Authorize]
        public IActionResult Fix(int issueId, int carId)
        {
           //var userIsMechanic = this.User.IsMechanic(this.User.Id);
           //
           // if (!userIsMechanic)
           // {
           //     return Unauthorized();
           // }

            this.issuesService.FixIssue(issueId, carId);

            return Redirect($"/Issues/AllIssues?carId={carId}");

        }


        [Authorize(Roles = AdministratorRoleName)]
        public IActionResult DeleteIssue(int issueId, int carId)
        {

            this.issuesService.DeleteToIssue(issueId, carId);

            return Redirect($"/Issues/AllIssues?carId={carId}");
        }
    }
}
