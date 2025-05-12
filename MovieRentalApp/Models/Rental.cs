namespace MovieRentalApp.Models;

public class Rental
{
    public int rental_id { get; set; }
    public DateTime rental_date { get; set; }
    public DateTime? return_date { get; set; }
    public int customer_id { get; set; }
    public int status_id { get; set; }
}