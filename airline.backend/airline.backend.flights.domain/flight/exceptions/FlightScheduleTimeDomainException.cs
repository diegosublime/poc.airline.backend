namespace airline.backend.flights.domain 
{ 
    public sealed class FlightScheduleTimeDomainException : Exception
    {
        public FlightScheduleTimeDomainException()
        {
        }

        public FlightScheduleTimeDomainException(string? message) : base(message)
        {
        }

        public FlightScheduleTimeDomainException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}