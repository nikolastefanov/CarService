using CarService.Data;
using CarService.Models;
using CarService.Models.Home;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CarService.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext data;

        public HomeController(ApplicationDbContext data)
        {
            this.data = data;
        }
 

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult IndexHome()
        {
            var issueType = this.data.IssueTypes
                 .Select(x => new IndexHomeViewModel
                 {
                     Name=x.Name,
                     ImageUrl=x.ImageUrl,
                 })
                 .ToList();


            
            return View(issueType);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
