﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarService.Controllers
{
    public class IssuesController : Controller
    {
        public IActionResult AddIssue()
        {
            return this.View();
        }
    }
}
