using airline.backend.shared;

namespace airline.backend.flights.domain 
{
    internal sealed record FlightScheduleChangedDomainEvent : IDomainEvent
    {
        public string EventName
        {
            get
            {
                return nameof(FlightScheduleChangedDomainEvent);
            }
        }

        public DateTime EventRisedTime { get; private set; }

        internal FlightScheduleChangedDomainEvent()
        {
            EventRisedTime = DateTime.UtcNow;
        }
    }
}
