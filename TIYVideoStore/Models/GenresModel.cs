using System.ComponentModel.DataAnnotations;

namespace TIYVideoStore.Models
{
    public class GenresModel
    {
        [Key]
        public int GenreID { get; set; }
        public string GenreName { get; set; }

    }
}