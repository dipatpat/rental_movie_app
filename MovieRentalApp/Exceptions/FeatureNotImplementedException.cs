namespace MovieRentalApp.Exceptions;

public class FeatureNotImplementedException : Exception
{
    public FeatureNotImplementedException(string message) : base(message) {}
}