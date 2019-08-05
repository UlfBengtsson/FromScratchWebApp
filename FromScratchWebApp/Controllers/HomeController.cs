using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FromScratchWebApp.Controllers
{
    // In other parts of the code we will refer to this controller with just "Home" as its name
    // (the controller part of the name will be automatecly added by MVC).
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();// defaults to looking for a view with the name of method name "Index"
        }

        public IActionResult Cars()
        {
            return View();
        }
    }
}