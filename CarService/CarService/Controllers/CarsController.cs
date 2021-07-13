
namespace CarService.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class CarsController : Controller
    {
        public IActionResult Add()
        {
            return this.View();
        }

        public IActionResult All()
        {
            return this.View();
        }
    }
}
