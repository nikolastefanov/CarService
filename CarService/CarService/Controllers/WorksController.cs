
namespace CarService.Controllers
{
    using CarService.Infrastructure;
    using CarService.Models.Works;
    using CarService.Services.Mechanics;
    using CarService.Services.Works;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using static WebConstants;

    public class WorksController : Controller
    {
        private readonly IWorksService worksService;
        private readonly IMechanicsService mechanicsService;
        public WorksController(IWorksService worksService,
                                IMechanicsService mechanicsService)
        {
            this.worksService = worksService;
            this.mechanicsService = mechanicsService;
        }


        [Authorize]
        public IActionResult  AddWorks()
        {
            var userId = this.User.GetId();

            var userIsMechanic = mechanicsService.IsMechanic(userId);

            if (!userIsMechanic)
            {
                return RedirectToAction("IndexIssueType", "IssueTypes");
            }

            return this.View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult AddWorks(int issueId,int carId,AddWorkViewModel work)
        {
            

            var userIdCar=this.worksService.GetUserId(carId);

            int workId=this.worksService
                .CreateWork(
                    userIdCar
                   ,issueId
                  ,work.Description
                 , work.Price
                 ,work.CarId);
            
            if (workId==0)
            {
                return BadRequest();
            }

            return Redirect($"/Orders/AddToOrder?workId={workId}&issueId={issueId}&carId={carId}");
  
      
        }

        [Authorize]
        public IActionResult AllWorks(int issueId,int carId)
        {

            var pr = this.worksService
                .GetAllWorks(issueId, carId)
                .Select(x => new ListingWorkViewModel
                {
                    Id = x.Id,
                    Description = x.Description,
                    IsFixed = x.IsFixed,
                    CarId = x.CarId,
                    Works = x.Works.Select(w => new WorkWorkViewModel
                    {
                        Id = w.Id,
                        Description = w.Description,
                        IssueId = w.IssueId,
                        Price = w.Price,
                    }).ToList(),
                }).FirstOrDefault();

            return this.View(pr);
            
        }

        [Authorize]
        public IActionResult EditWorks(int workId, int issueId, int carId)
        {
            ;
            var workEdit=this.worksService.DetailsWork(workId, issueId, carId);

            return this.View(new EditWorkViewModel
            {
               Id=workEdit.Id,
               Description=workEdit.Description,
               IssueId=workEdit.IssueId,
               Price=workEdit.Price,
            });
        }

        [Authorize]
        [HttpPost]
        public IActionResult EditWorks(int workId
            , int issueId
            , int carId
            , EditWorkViewModel work)
        {

            var workEdit = this.worksService
                .EditToWork(workId
                , issueId
                , carId
                , work.Description
                , work.Price);

            if (!workEdit)
            {
                return BadRequest();
            }

            return Redirect($"/Works/AllWorks?issueId={issueId}&carId={carId}");
        }


        [Authorize]
        public IActionResult DeleteWorks(int workId,int issueId,int carId)
        {
            this.worksService.DeleteToWork(workId, issueId,carId);

            return Redirect($"/Works/AllWorks?issueId={issueId}&carId={carId}");
        }

    }
}
