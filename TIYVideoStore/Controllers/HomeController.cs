using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TIYVideoStore.Models;

namespace TIYVideoStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly videodbContext _context;

        public HomeController(videodbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Overdue()
        {
            return View();
        }

        public IActionResult Return()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
