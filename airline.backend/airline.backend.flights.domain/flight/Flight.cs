using airline.backend.flights.domain.flight;
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
            AirplaneId airplaneId):base(flightId)
        {
            Id = flightId;
            Code = flightCode;
            Origin = origin;
            Destination = destination;
            FlightSchedule = flightSchedule;
            AirplaneId = airplaneId;
        }
         
        public FlightCode Code { get; private set; }
        public Airport Origin { get; private set; }
        public Airport Destination { get; private set; }
        public FlightSchedule FlightSchedule { get; private set; }
        public AirplaneId AirplaneId { get; private set; }


        public static Flight ProgamFlight(FlightCode flightCode, 
            Airport origin, 
            Airport destination, 
            FlightSchedule flightSchedule, 
            AirplaneId airplaneId, 
            FlightId? flightId = default)
        {
            FlightId id = flightId ?? FlightId.Create(); 
            return new Flight(id, flightCode, origin, destination, flightSchedule, airplaneId);
        }

        public void ChangeFlightSchedule(FlightSchedule newFlightSchedule) 
        {
            FlightSchedule = newFlightSchedule;
            this.RiseDomainEvent(FlightEvents.FlightScheduleChangedDomainEvent());
        }
    }
}
