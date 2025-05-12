using System.ComponentModel.DataAnnotations;

namespace MovieRentalApp.Models;

public class Customer
{
    public int customer_id { get; set; }
    
    [MaxLength(100)]
    public string first_name { get; set; }
    
    [MaxLength(200)]
    public string last_name { get; set; }
    
}