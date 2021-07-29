

namespace CarService.Controllers
{
    using CarService.Data;
    using CarService.Data.Models;
    using CarService.Models.Issues;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;


    public class IssuesController : Controller
    {
        // private readonly ApplicationDbContext data;
        //
        // public IssuesController(ApplicationDbContext data)
        // {
        //     this.data = data;
        // }
        //
        // public IActionResult AddIssue()
        // {
        //     return this.View();
        // }
        //
        //[HttpPost]
        //public IActionResult AddIssue(IssueInputFormModel issue, int carId)
        //{
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
        //
        //    return RedirectToAction("All", "Cars");

        //  }

    //   private IEnumerable<IssueTypeViewModel> GetIssueTypes()
    //       => this.data
    //           .IssueTypes
    //           .Select(c => new IssueTypeViewModel
    //           {
    //               Id = c.Id,
    //               Name = c.Name,    
    //           })
    //           .ToList();
    }
}
