using airline.backend.flights.domain.flight;

namespace airline.backend.flights.domain
{
    public sealed class Flight
    {
        private Flight(FlightId flightId, 
            FlightCode flightCode, 
            Airport origin, 
            Airport destination, 
            FlightSchedule flightSchedule,
            AirplaneId airplaneId)
        {
            FlightId = flightId;
            Code = flightCode;
            Origin = origin;
            Destination = destination;
            FlightSchedule = flightSchedule;
            AirplaneId = airplaneId;
        }

        public FlightId FlightId { get; private set; }
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
            //Trigger a domain event
            return new Flight(id, flightCode, origin, destination, flightSchedule, airplaneId);
        }

        public void ChangeFlightSchedule(FlightSchedule newFlightSchedule) 
        {
            FlightSchedule = newFlightSchedule;
            //Trigger a domain event
        }
    }
}
