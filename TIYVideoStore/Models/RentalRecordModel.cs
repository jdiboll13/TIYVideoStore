using System;

namespace TIYVideoStore.Models
{
    public class RentalRecordModel
    {
        public int RentalID { get; set; }
        public int MovieID { get; set; }
        public int CustomerID { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime ReturnDate { get; set; }
        
    }
}