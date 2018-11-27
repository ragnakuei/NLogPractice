using System.Diagnostics;
using ClassLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NLogPractice.Models;

namespace NLogPractice.Controllers
{
    public class HomeController : Controller
    {
        private readonly ClassBL _classBL;

        public HomeController(ClassBL classBL)
        {
            this._classBL = classBL;
        }
        
        public IActionResult Index()
        {
            _classBL.Log();

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
