
namespace CarService.Controllers
{
    using CarService.Models.Mechanics;
    using CarService.Services.Mechanics;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;


    public class MechanicsController : Controller
    {
        private readonly IMechanicsService mechanicsService;

        public MechanicsController(IMechanicsService mechanicsService)
        {
            this.mechanicsService = mechanicsService;
        }
        public IActionResult Become()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Become(BecomeMechanicViewModel mechanic)
        {
            // var userId = this.User.Id();
            //
            // var userIdAlreadyDealer = this.data
            //     .Dealers
            //     .Any(d => d.UserId == userId);
            //
            // if (userIdAlreadyDealer)
            // {
            //     return BadRequest();
            // }
            //
            // if (!ModelState.IsValid)
            // {
            //     return View(dealer);
            // }

            // var dealerData = new Dealer
            // {
            //     Name = dealer.Name,
            //     PhoneNumber = dealer.PhoneNumber,
            //     UserId = userId
            // };
            //

            var isMechanic = this.mechanicsService
                .BecomeMechanic(
                mechanic.FullName);
                //, mechanic.PhoneNumber);

            if (!isMechanic)
            {
                return BadRequest();
            }


            return RedirectToAction("All", "Cars");
        }

    }
}
