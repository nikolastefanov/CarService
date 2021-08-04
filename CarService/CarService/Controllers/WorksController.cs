
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
        private readonly IWorksService worksService;

        public WorksController(IWorksService worksService)
        {
            this.worksService = worksService;
        }


        public IActionResult  AddWorks()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult AddWorks(int issueId,int carId,AddWorkViewModel work)
        {
            var isWork=this.worksService
                .CreateWork(
                   issueId
                  ,work.Description
                 , work.Price);

            if (!isWork)
            {
                return BadRequest();
            }
            return Redirect($"/Works/AllWorks?issueId={issueId}&carId={carId}");
            
            //return this.RedirectToAction("AllWorks","Works",new {issueId=issueId,carId=carId});
        }

        public IActionResult AllWorks(int issueId,int carId)
        {

            var workData = this.worksService.GetAllWorks(issueId,carId);

            var workDataView = workData
                .Select(x => new WorkWorkViewModel
                {
                    Id=x.Id,
                    IssueId=x.IssueId,
                    Description=x.Description,
                    Price=x.Price,
                })
                .ToList();

            return this.View(workDataView);
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
