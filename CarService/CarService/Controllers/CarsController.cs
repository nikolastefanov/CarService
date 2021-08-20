
namespace CarService.Controllers
{
    using CarService.Data;
    using CarService.Data.Models;
    using CarService.Infrastructure;
    using CarService.Models.Cars;
    using CarService.Models.IssueTypes;
    using CarService.Services.Cars;
    using CarService.Services.Mechanics;
    using CarService.Services.Orders;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using static WebConstants;
    public class CarsController : Controller
    {
        private readonly ICarsService carsService;
        private readonly IMechanicsService mechanicsService;
        private readonly IOrdersService ordersService;
        public CarsController(ICarsService carsService,
            IOrdersService ordersService,
            IMechanicsService mechanicsService)
        {
            this.carsService = carsService;
            this.ordersService = ordersService;
            this.mechanicsService = mechanicsService;
        }

        [Authorize]
        public IActionResult Add()
        {
            var issueTypes = carsService
                .AllIssueTypes()
                .Select(x => new IndexIssueTypeViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    ImageUrl=x.ImageUrl,
                }).ToList();


            return this.View(new AddCarFormModel
            {
                IssueTypes= issueTypes,

            }) ;
        }

        [Authorize]
        [HttpPost]
        public IActionResult Add(AddCarFormModel car)
        {
            var userId = this.User.GetId();

            this.carsService.AddCar(userId
                ,car.Make
                ,car.Model
                ,car.PlateNumber
                ,car.ImageUrl
                ,car.Year
                ,car.IssueTypeId
                );

            var isOrder = this.ordersService.OrderExists(userId);

            if (!isOrder)
            {
                return RedirectToAction("CreateOrder","Orders");
            }


            return RedirectToAction("All","Cars");
         
        }

        [Authorize]
        public IActionResult All()
        {  

            var userId = this.User.GetId();

            var userIsMechanic = mechanicsService.IsMechanic(userId);

            if (!userIsMechanic)
            {

                 var carsData = this.carsService
                    .GetAllCar(userId)
                    .Select(x => new CarListingViewModel
                    {
                        Id = x.Id,
                        Make = x.Make,
                        Model = x.Model,
                        PlateNumber = x.PlateNumber,
                        ImageUrl = x.ImageUrl,
                        Year = x.Year,
                        IssueType = x.IssueType,
                        RemainingIssues = x.RemainingIssues,
                        FixedIssues = x.FixedIssues,
                    })
                    .ToList();

                return this.View(carsData);
            }
            else if(userIsMechanic)
            {
                 var carsData1 = this.carsService
                   .GetAllCar()
                   .Select(x => new CarListingViewModel
                   {
                       Id = x.Id,
                       Make = x.Make,
                       Model = x.Model,
                       PlateNumber = x.PlateNumber,
                       ImageUrl = x.ImageUrl,
                       Year = x.Year,
                       IssueType = x.IssueType,
                       RemainingIssues = x.RemainingIssues,
                       FixedIssues = x.FixedIssues,
                   })
                   .ToList();

                return this.View(carsData1);
            }

            if (User.IsAdmin())
            {
                return Redirect("/Admin/Cars/All");
            }

            return this.RedirectToAction("IndexIssueType","IssueTypes");
        }

        
        [Authorize]
        public IActionResult Edit(int carId)
        {
         
            var carEdit = this.carsService.CarDetails(carId);
            

           var issueTypes = this.carsService
                   .AllIssueTypes()
                   .Select(x => new IndexIssueTypeViewModel
                   {
                       Id = x.Id,
                       Name = x.Name,
                       ImageUrl = x.ImageUrl,
                   }).ToList();
            

            return this.View(new EditCarViewModel
            {
                Id=carEdit.Id,
                Make=carEdit.Make,
                Model=carEdit.Model,
                PlateNumber=carEdit.PlateNumber,
                ImageUrl=carEdit.ImageUrl,
                Year=carEdit.Year,
                IssueTypeId=carEdit.IssueTypeId,
                IssueTypes=issueTypes,
            });
        }



        [Authorize]
        [HttpPost]
        public IActionResult Edit(int carId,EditCarViewModel car)
        {
            var carEdit=this.carsService.EditCar(
                             carId
                             ,car.Make
                             ,car.Model
                             ,car.PlateNumber
                             ,car.ImageUrl
                             ,car.Year
                             ,car.IssueTypeId);

            if (!carEdit)
            {
                return BadRequest();
            }

            return RedirectToAction("All","Cars");
        }

        [Authorize(Roles = AdministratorRoleName)]
        public IActionResult DeleteCar(int carId)
        {
            this.carsService.DeleteCar(carId);

            return this.RedirectToAction("All","Cars");
        }
    }
}
