
namespace CarService.Controllers
{
    using CarService.Models.Mechanics;
    using CarService.Services.Mechanics;
    using CarService.Infrastructure;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using CarService.Data.Models;

    public class MechanicsController : Controller
    {
        private readonly IMechanicsService mechanicsService;

        public MechanicsController(IMechanicsService mechanicsService)
        {
            this.mechanicsService = mechanicsService;
        }
        [Authorize]
        public IActionResult Become()
        {
            return this.View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult Become(BecomeMechanicViewModel mechanic)
        {
               var userId = this.User.GetId();
              
            
             
               if (!ModelState.IsValid)
               {
                   return View(mechanic);
               }
      

            var isMechanic = this.mechanicsService
                .BecomeMechanic(
                mechanic.FullName
                , mechanic.PhoneNumber
                ,userId);

            if (!isMechanic)
            {
                return BadRequest();
            }


            return RedirectToAction("IndexIssueType", "IssueTypes");
        }

    }
}
