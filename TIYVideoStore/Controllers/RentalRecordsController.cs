using System;
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
            var service = new MovieService(_context);
            return View(service.GetAllMovies());
        }

        public IActionResult Create(int ID)
        {   
            var movieForm = new MovieService(_context);
            return View(movieForm.CreateRentalRecord());
        }

        [HttpPost]
        public IActionResult CreateRecord(int movie, int customer, DateTime rentaldate, DateTime duedate)
        {
            var newRecord = new RentalRecordsModel
            {
                MovieID = movie,
                CustomerID = customer,
                RentalDate = rentaldate,
                DueDate = duedate
            };
            _context.RentalRecords.Add(newRecord);
            _context.SaveChanges();
            return Redirect("Index");
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
