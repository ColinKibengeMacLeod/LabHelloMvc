using System.Diagnostics;
using LabHelloMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace LabHelloMvc.Controllers
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

            Person person1 = new Person();
            person1.PersonId = 1;
            person1.FirstName = "Colin";
            person1.LastName = "Kibenge-MacLeod";

            return View(person1);
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
