using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TIYVideoStore.Models;

namespace TIYVideoStore.Controllers
{
    public class RentalRecordsController : Controller
    {
		private readonly videodbContext _context;

		public RentalRecordsController(videodbContext context)
		{
			_context = context;
		}
        
        public IActionResult Index()
        {
            var currentMovies = _context.Movies.ToList();
            return View(currentMovies);
        }

        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
