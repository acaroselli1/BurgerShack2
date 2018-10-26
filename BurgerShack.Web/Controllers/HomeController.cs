using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BurgerShack.Web.Models;
using BurgerShack.Entities;
using BurgerShack.Business;

namespace BurgerShack.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly BurgersService _burgersService;

        public HomeController(BurgersService burgersService)
        {
            _burgersService = burgersService;
        }
        //default route/view
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Burgers()
        {   
            return View(_burgersService.GetAll());
        }
    }
}
