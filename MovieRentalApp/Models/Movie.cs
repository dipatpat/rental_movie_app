using System.ComponentModel.DataAnnotations;

namespace MovieRentalApp.Models;

public class Movie
{
    public int movie_id { get; set; }
    
    [MaxLength(200)]
    public string title { get; set; }
    
    public DateTime release_date { get; set; }
    
    public decimal price_per_day { get; set; }
}