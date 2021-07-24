
namespace CarService.Controllers
{
    using CarService.Data;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class SparePartsController:Controller
    {
        private readonly ApplicationDbContext data;

        public SparePartsController(ApplicationDbContext data)
        {
            this.data = data;
        }


        public IActionResult AddSpareParts()
        {


            return this.View();
        }

        public IActionResult AllSpareParts()
        {


            return this.View();
        }


        public IActionResult DetailsSpareParts()
        {

            return this.View();
        }

        public IActionResult UpdateSpareParts()
        {

            return this.View();
        }


        public IActionResult DeleteSpareParts()
        {

            return this.View();
        }

    }
}
