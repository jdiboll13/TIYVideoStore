using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TIYVideoStore.Models;

namespace TIYVideoStore.Controllers
{
    public class MoviesController : Controller
    {
        private readonly videodbContext _context;

		public MoviesController(videodbContext context)
		{
			_context = context;
		}
        
        public IActionResult Index()
        {
            var service = new MovieService(_context);
            return View(service.GetAllMovies());
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
