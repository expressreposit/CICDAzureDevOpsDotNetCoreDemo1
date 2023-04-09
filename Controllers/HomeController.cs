using CICDAzureDevOpsDotNetCoreDemo1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CICDAzureDevOpsDotNetCoreDemo1.Controllers
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
            var valuesNumber = 1234;
            var Asmita = 16;
            return View(valuesNumber);
        }

        public IActionResult Privacy()
        {
            var valuesNumber = 1234;
            return View(valuesNumber);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}