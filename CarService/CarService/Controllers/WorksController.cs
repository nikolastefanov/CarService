
namespace CarService.Controllers
{
    using CarService.Models.Works;
    using CarService.Services.Works;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;



    public class WorksController : Controller
    {
        private readonly IWorksService worsService;

        public WorksController(IWorksService worsService)
        {
            this.worsService = worsService;
        }


        public IActionResult  AddWorks()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult AddWorks(int issueId,AddWorkViewModel work)
        {
            var isWork=this.worsService
                .CreateWork(
                   issueId
                  ,work.Description
                 , work.Price);

            if (!isWork)
            {
                return BadRequest();
            }

            return this.RedirectToAction("AllWorks");
        }

        public IActionResult AllWorks()
        {
            return this.View();
        }

        public IActionResult EditWorks()
        {
            return this.View();
        }

        public IActionResult DeleteWorks()
        {
            return this.View();
        }

    }
}
