
namespace CarService.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;



    public class WorksController : Controller
    {
        public IActionResult  AddWorks()
        {
            return this.View();
        }

        public IActionResult AllWorks()
        {
            return this.View();
        }

        public IActionResult UpdateWorks()
        {
            return this.View();
        }

        public IActionResult DeleteWorks()
        {
            return this.View();
        }

    }
}
