using System.ComponentModel.DataAnnotations;

namespace TIYVideoStore.Models
{
    public class CustomersModel
    {
        [Key]
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        
    }
}