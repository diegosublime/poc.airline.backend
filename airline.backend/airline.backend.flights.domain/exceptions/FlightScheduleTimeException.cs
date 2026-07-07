namespace airline.backend.flights.domain 
{ 
    public class FlightScheduleTimeException : Exception
    {
        public FlightScheduleTimeException()
        {
        }

        public FlightScheduleTimeException(string? message) : base(message)
        {
        }

        public FlightScheduleTimeException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}