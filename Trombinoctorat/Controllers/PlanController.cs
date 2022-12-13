using Microsoft.AspNetCore.Mvc;

namespace Trombinoctorat.Controllers
{
    public class PlanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
