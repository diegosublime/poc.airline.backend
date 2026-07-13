using airline.backend.flights.domain.flight;
using airline.backend.flights.domain.flight.exceptions;
using airline.backend.shared;

namespace airline.backend.flights.domain
{
    public sealed class Flight: AggregateRoot<FlightId>
    {
        private Flight(FlightId flightId, 
            FlightCode flightCode, 
            Airport origin, 
            Airport destination, 
            FlightSchedule flightSchedule,
            SeatCapacity seatCapacity,
            AirplaneId airplaneId): base(flightId)
        {
            Id = flightId;
            Code = flightCode;
            Origin = origin;
            Destination = destination;
            FlightSchedule = flightSchedule;
            AirplaneId = airplaneId;
            SeatCapacity = seatCapacity;
            SeatsReservedQuantity = SeatsReservedQuantity.Create();
        }
         
        public FlightCode Code { get; private set; }
        public Airport Origin { get; private set; }
        public Airport Destination { get; private set; }
        public FlightSchedule FlightSchedule { get; private set; }
        public AirplaneId AirplaneId { get; private set; }
        public SeatCapacity SeatCapacity { get; private set; }
        public SeatsReservedQuantity SeatsReservedQuantity { get; private set; }


        public static Flight Create(FlightCode flightCode, 
            Airport origin, 
            Airport destination, 
            FlightSchedule flightSchedule, 
            AirplaneId airplaneId,
            SeatCapacity seatCapacity,
            FlightId? flightId = default)
        {
            FlightId id = flightId ?? FlightId.Create(); 
            return new Flight(id, flightCode, origin, destination, flightSchedule, seatCapacity, airplaneId);
        }

        public void ChangeFlightSchedule(FlightSchedule newFlightSchedule) 
        {
            FlightSchedule = newFlightSchedule;
            this.RiseDomainEvent(new FlightScheduleChangedDomainEvent());
        }

        public void ReserveSeats(int seatsToReserve) 
        {
            if (seatsToReserve < 1 || seatsToReserve > 900)
            {
                throw new ArgumentException("Invalid number of seats for an airplane");
            }

            int newTotalReservedSeats = SeatsReservedQuantity.Value + seatsToReserve;

            if (newTotalReservedSeats > SeatCapacity.Value) 
            {
                throw new FlightCapacityExceededDomainException("Flight cant take more reservations due to capacity limit reached");
            }

            SeatsReservedQuantity = SeatsReservedQuantity.Create(newTotalReservedSeats);
        }
    }
}
