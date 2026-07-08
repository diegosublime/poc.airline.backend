using System.Runtime.CompilerServices;

namespace airline.backend.flights.domain.flight
{
    public sealed record FlightSchedule
    { 
        public DateTimeOffset DepartureDateTime { get; private set; }
        public DateTimeOffset ArrivalDateTime { get; private set; }
        public TimeSpan FlightDuration { get; private set; }

        private FlightSchedule(DateTimeOffset departureDateTime, DateTimeOffset arrivalDateTime, TimeSpan flightDuration)
        {
            DepartureDateTime = departureDateTime;
            ArrivalDateTime = arrivalDateTime;
            FlightDuration = flightDuration;
        }

        public static FlightSchedule Create(DateTimeOffset departureDateTime, DateTimeOffset arrivalDateTime)
        {
            if (departureDateTime >= arrivalDateTime) 
            {
                throw new FlightScheduleTimeDomainException("deparure time can not happen after arrival time");
            }

            TimeSpan flightDuration = arrivalDateTime - departureDateTime;

            return new FlightSchedule(departureDateTime, arrivalDateTime, flightDuration);
        }
    }
}
