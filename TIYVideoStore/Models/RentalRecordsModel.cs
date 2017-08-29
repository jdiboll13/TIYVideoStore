using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TIYVideoStore.Models
{
    public class RentalRecordModel
    {
        [Key]
        public int RentalID { get; set; }

        [ForeignKey("MovieID")]
        public int MovieID { get; set; }
        public MoviesModel MoviesModel { get; set; }

        [ForeignKey("CustomerID")]
        public int CustomerID { get; set; }
        public CustomersModel CustomersModel { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime ReturnDate { get; set; }

    }
}