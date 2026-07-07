namespace airline.backend.flights.domain.flight
{
    internal static class FlightEvents
    {
        internal static FlightScheduleChangedDomainEvent FlightScheduleChangedDomainEvent()
        {
            return new FlightScheduleChangedDomainEvent();
        }
    }
}
