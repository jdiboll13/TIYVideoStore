using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using TIYVideoStore.Models;

namespace TIYVideoStore
{
    class MovieService
    {
        private readonly videodbContext _context;

        public MovieService(videodbContext context)
        {
            _context = context;
        }
        public IEnumerable<MoviesViewModel> GetAllMovies()
        {
            var CurrentMovies = _context.Movies;
            return CurrentMovies.Include(i => i.GenresModel).Select(s => new MoviesViewModel(s));
        }

        public CreateRecordViewModel CreateRentalRecord()
        {
            var customerInfo = _context.Customers;
            var movieInfo = _context.Movies;
            var newRecord = new CreateRecordViewModel
            {
                Customers = customerInfo.ToList(),
                Movies = movieInfo.ToList(),
            };

            return newRecord;
        }

        public IEnumerable<RentalRecordViewModel> GetAllRentalRecords()
        {
            var RentalRecord = _context.RentalRecords;
            return RentalRecord.Include(i => i.MoviesModel).Include(i => i.CustomersModel).Select(s => new RentalRecordViewModel(s));
        }
    }
}