using airline.backend.reservations.domain.reservation;
using airline.backend.shared;

namespace airline.backend.reservations.domain
{
    internal sealed record ReservationCreatedDomainEvent : IDomainEvent
    {
        public string EventName
        {
            get
            {
                return nameof(ReservationCreatedDomainEvent);
            }
        }

        public ReservationId ReservationId { get; private set; }

        public DateTime EventRisedTime { get; private set; }

        internal ReservationCreatedDomainEvent(ReservationId reservationId)
        {
            EventRisedTime = DateTime.UtcNow;
            ReservationId = reservationId;
        }
    }
}
