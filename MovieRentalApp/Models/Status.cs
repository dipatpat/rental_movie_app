using System.ComponentModel.DataAnnotations;

namespace MovieRentalApp.Models;

public class Status
{
    public int status_id { get; set; }
    
    [MaxLength(200)]
    public string name { get; set; }
}