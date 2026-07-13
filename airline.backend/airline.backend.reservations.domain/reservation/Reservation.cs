using airline.backend.shared;

namespace airline.backend.reservations.domain.reservation
{
    public sealed class Reservation : AggregateRoot<ReservationId>
    {
        private Reservation(ReservationId id, UserId userId, FlightId flightId, Money cost) : base(id)
        {
            UserId = userId;
            FlightId = flightId;
            Cost = cost;
        }

        public UserId UserId { get; private set; }
        public FlightId FlightId { get; private set; }
        public Money Cost { get; private set; }

        public static Reservation Create(UserId userId, FlightId flightId, Money cost, ReservationId? id = default)
        {
            ReservationId reservationId = id ?? ReservationId.Create();
            var reservation = new Reservation(reservationId, userId, flightId, cost);
            reservation.RiseDomainEvent(new ReservationCreatedDomainEvent(reservationId));

            return reservation;
        }
         
    }
}
