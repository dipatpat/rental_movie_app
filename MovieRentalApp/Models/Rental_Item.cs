namespace MovieRentalApp.Models;

public class Rental_Item
{
    public int rental_id { get; set; }
    public int movie_id { get; set; }
    public decimal price_at_rental { get; set; }
}