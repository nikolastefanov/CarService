

namespace CarService.Areas.Admin.Controllers
{
    using CarService.Models.Cars;
    using CarService.Services.Cars;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using static AdminConstants;


    public class CarsController : AdminController
    {
        private readonly ICarsService cars;

        public CarsController(ICarsService cars)
        {
            this.cars = cars;
        }

        public IActionResult All()
        {
            var carsData = this.cars
                .GetAllCarAdmin()
                .Select(x => new CarAdminViewModel
                {
                    Id=x.Id,
                    Make=x.Make,
                    Model=x.Model,
                    ImageUrl=x.ImageUrl,
                    PlateNumber=x.PlateNumber,
                    Year=x.Year,
                    IssueTypeName=x.IssueTypeName,
                }).ToList();

            return View(carsData);
        }

    }
}
