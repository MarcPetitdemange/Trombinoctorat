using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Trombinoctorat.Models;

namespace Trombinoctorat.Controllers
{
    public class AccueilController : Controller
    {
        private readonly ILogger<AccueilController> _logger;


        public AccueilController(ILogger<AccueilController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
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