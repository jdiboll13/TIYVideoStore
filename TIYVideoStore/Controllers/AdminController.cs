using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TIYVideoStore.Models;

namespace TIYVideoStore.Controllers
{
    public class AdminController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
