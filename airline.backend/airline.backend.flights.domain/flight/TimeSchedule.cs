namespace airline.backend.flights.domain.flight
{
    public sealed record FlightSchedule
    {
        public DateTimeOffset DepartureTime { get; private set; }
        public DateTimeOffset ArrivalTime { get; private set; }
        public TimeSpan FlightDuration { get; set; }

        private FlightSchedule(DateTimeOffset departureTime, DateTimeOffset arrivalTime, TimeSpan flightDuration)
        {
            DepartureTime = departureTime;
            ArrivalTime = arrivalTime;
            FlightDuration = flightDuration;
        }

        public static FlightSchedule Create(DateTimeOffset departureTime, DateTimeOffset arrivalTime)
        {
            if (departureTime >= arrivalTime) 
            {
                throw new FlightScheduleTimeDomainException("deparure time can not happen after arrival time");
            }

            TimeSpan flightDuration = arrivalTime - departureTime;

            return new FlightSchedule(departureTime, arrivalTime, flightDuration);
        }
    }
}
