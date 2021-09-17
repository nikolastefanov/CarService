

namespace CarService.Controllers
{
    using CarService.Infrastructure;
    using CarService.Models.IssueTypes;
    using CarService.Services;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Caching.Memory;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using static WebConstants;
    using static WebConstants.Cache;


    public class IssueTypesController :Controller
    {
        private readonly IIssueTypesService service;
        private readonly IMemoryCache cache;

        public IssueTypesController(IIssueTypesService service, IMemoryCache cache)
        {
            this.service = service;
            this.cache = cache;
        }

        public IActionResult IndexIssueType()
        {

            if (User.IsAdmin())
            {
                var issueTypeAdmin = this.service
                  .GetAllCategory()
                  .Select(x => new IndexIssueTypeViewModel
                  {
                      Id = x.Id,
                      Name = x.Name,
                      ImageUrl = x.ImageUrl,

                  }).ToList();
                return View(issueTypeAdmin);
            }
            
                var issueType = this.cache.Get<List<IndexIssueTypeViewModel>>(IssueTypeCacheKey);

                if (issueType == null)
                {
                    issueType = this.service
                       .GetAllCategory()
                       .Select(x => new IndexIssueTypeViewModel
                       {
                           Id = x.Id,
                           Name = x.Name,
                           ImageUrl = x.ImageUrl,

                       }).ToList();



                    var cacheOptions = new MemoryCacheEntryOptions()
                        .SetAbsoluteExpiration(TimeSpan.FromMinutes(1));

                    this.cache.Set(IssueTypeCacheKey, issueType, cacheOptions);
                }
            

            return View(issueType);
        }

   
        [Authorize]
        public IActionResult AddIssueType()
        {
            if (!User.IsAdmin())
            {
                return RedirectToAction("IndexIssueType");
            }
            return this.View();
        }


        [Authorize(Roles = AdministratorRoleName)]
        [HttpPost]
        public IActionResult AddIssueType(IssueTypeViewModel issueType)
        {
            this.service.
                AddNewCategory(
                issueType.Name,
                issueType.ImageUrl);

            return this.RedirectToAction("IndexIssueType");
        }

        [Authorize(Roles = AdministratorRoleName)]
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

  
        [Authorize(Roles = AdministratorRoleName)]
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

        [Authorize(Roles = AdministratorRoleName)]
        public IActionResult DeleteIssueType(int issueTypeId)
        {
            this.service.Delete(issueTypeId);

            return this.RedirectToAction("IndexIssueType");
        }
    }
}
