using System;
using System.ComponentModel.DataAnnotations;

namespace TIYVideoStore.Models
{
    public class GenreModel
    {
        [Key]
        public int GenreID { get; set; }
        public string GenreName { get; set; }

    }
}