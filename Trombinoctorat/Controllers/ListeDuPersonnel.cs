using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using Trombinoctorat.Models;

namespace Trombinoctorat.Controllers
{
    public class ListeDuPersonnel : Controller
    {

        RectoratContext _context = new RectoratContext();

        public IActionResult Index()
        {
            List<Employe> Employes = _context.Employe.ToList();
           
            return View(Employes);
        }
    }
}
