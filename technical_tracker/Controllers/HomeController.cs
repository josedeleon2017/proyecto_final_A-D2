using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using technical_tracker.demo;
using technical_tracker.Models;

namespace technical_tracker.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //EmpleadoFactory factory = new ConcreteEmpleadoFactory();

            //IFactory t = factory.GetEmpleado("Tecnico");
            //t.getProfile("10");

            //IFactory s = factory.GetEmpleado("Supervisor");
            //s.getProfile("20");

           // ViewBag.text = t.getName();

            return View();
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
