using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab18_CoffeeShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab18_CoffeeShop.Controllers
{
    public class RegistrationController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new RegisterUser());
        }


        [HttpPost]
        public IActionResult Index(RegisterUser user)
        {
            return RedirectToAction("Summary", user);
        }
        
        public IActionResult Summary(RegisterUser user)
        {
            return View(user);
        }


        
    }
}