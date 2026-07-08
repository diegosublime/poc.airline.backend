using airline.backend.shared;

namespace airline.backend.flights.domain 
{
    public sealed class Airplane : AggregateRoot<AirplaneId>
    {
        private Airplane(AirplaneId id, AirplaneModel model, AirplaneSeatsCapacity seatsCapacity) : base(id)
        {
            Model = model;
            SeatsCapacity = seatsCapacity;
        }

        public AirplaneModel Model { get; private set; }
        public AirplaneSeatsCapacity SeatsCapacity { get; private set; }

        public static Airplane Create(AirplaneModel model, AirplaneSeatsCapacity seatsCapacity, AirplaneId? id = default) 
        {
            if (model is null || seatsCapacity is null)
            {
                throw new ArgumentNullException("Model and SeatCapacity are required");
            }

            AirplaneId airplaneId = id ?? AirplaneId.Create();
            return new Airplane(airplaneId, model, seatsCapacity);
        }
    }
}