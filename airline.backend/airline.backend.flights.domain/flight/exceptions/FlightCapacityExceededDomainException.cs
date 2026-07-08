namespace airline.backend.flights.domain.flight.exceptions
{
    public sealed class FlightCapacityExceededDomainException : Exception
    {
        public FlightCapacityExceededDomainException()
        {
        }

        public FlightCapacityExceededDomainException(string? message) : base(message)
        {
        }

        public FlightCapacityExceededDomainException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
