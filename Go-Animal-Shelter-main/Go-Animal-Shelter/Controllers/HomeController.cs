using Go_Animal_Shelter.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Go_Animal_Shelter.Controllers
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
            return View();
        }

       
    }
}