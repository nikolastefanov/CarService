
namespace CarService.Controllers
{
    using CarService.Data;
    using CarService.Data.Models;
    using CarService.Infrastructure;
    using CarService.Models.Cars;
    using CarService.Models.IssueTypes;
    using CarService.Services.Cars;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class CarsController : Controller
    {
        private readonly ICarsService carsService;

        public CarsController(ICarsService carsService)
        {
            this.carsService = carsService;
        }

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

            return RedirectToAction("All","Cars");
         
        }

        public IActionResult All()
        {
            var carsData = this.carsService
                .GetAllCar()
                .Select(x => new CarListingViewModel
                {
                    Id=x.Id,
                    Make=x.Make,
                    Model=x.Model,
                    PlateNumber=x.PlateNumber,
                    ImageUrl=x.ImageUrl,
                    Year=x.Year,
                    IssueType=x.IssueType,
                    RemainingIssues =x.RemainingIssues,
                    FixedIssues = x.FixedIssues,
                })
                .ToList();

            return this.View(carsData);
        }

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

            return RedirectToAction("All");
        }

        public IActionResult DeleteCar(int carId)
        {
            this.carsService.DeleteCar(carId);

            return this.RedirectToAction("All");
        }
    }
}
