using CarService.Models.IssueTypes;
using CarService.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarService.Controllers
{
    public class IssueTypesController :Controller
    {
        private readonly IIssueTypesService service;

        public IssueTypesController(IIssueTypesService service)
        {
            this.service = service;
        }

        public IActionResult IndexIssueType()
        {
            var issueType = this.service
                .GetAllCategory()
                .Select(x => new IndexIssueTypeViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    ImageUrl = x.ImageUrl,

                }).ToList();

            return View(issueType);
        }

        public IActionResult AddIssueType()
        {
            return this.View();
        }


        [HttpPost]
        public IActionResult AddIssueType(IssueTypeViewModel issueType)
        {
            this.service.
                AddNewCategory(
                issueType.Name,
                issueType.ImageUrl);

            return this.RedirectToAction("IndexIssueType");
        }


        public IActionResult EditIssueType(int issueTypeId)
        {
            var issueType = this.service.Details(issueTypeId);

            return this.View(new EditIssueTypeViewModel
            {
                Id=issueType.Id,
                Name=issueType.Name,
                ImageUrl=issueType.ImageUrl,
            });

        }


        [HttpPost]
        public IActionResult EditIssueType(int issueTypeId,IssueTypeViewModel issueType)
        {

            var issueTypeEdit = this.service
                .Edit(
                issueTypeId,
                issueType.Name,
                issueType.ImageUrl
                );

            if (!issueTypeEdit)
            {
                return BadRequest();
            }

            return RedirectToAction("IndexIssueType");
        }


        public IActionResult DeleteIssueType(int issueTypeId)
        {
            this.service.Delete(issueTypeId);

            return this.RedirectToAction("IndexIssueType");
        }
    }
}
