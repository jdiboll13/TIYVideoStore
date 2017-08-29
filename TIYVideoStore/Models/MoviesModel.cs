using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TIYVideoStore.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace TIYVideoStore.Models
{
    public class MoviesModel
    {
        [Key]
        public int MovieID { get; set; }
        public string MovieName { get; set; }
        public string MovieDescription { get; set; }
        [ForeignKey("GenreID")]
        public int GenreID { get; set; }
        public GenreModel GenreModel { get; set; }

    }
}