
namespace CarService.Controllers
{
    using CarService.Data;
    using CarService.Data.Models;
    using CarService.Models.Cars;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class CarsController : Controller
    {
        private readonly ApplicationDbContext data;

        public CarsController(ApplicationDbContext data)
        {
            this.data = data;
        }

        public IActionResult Add()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Add(AddCarFormModel car)
        {

            var carData = new Car
            {
                Make = car.Make,
                Model = car.Model,
                ImageUrl = car.ImageUrl,
                Year = car.Year,
               PlateNumber=car.PlateNumber,

            };

            this.data.Cars.Add(carData);
            this.data.SaveChanges();

            return RedirectToAction("AddIssue","Issues");
          
        }

        public IActionResult All()
        {
            return this.View();
        }
    }
}
