namespace airline.backend.reservations.domain
{
    public sealed record FlightId
    {
        public Guid Value { get; private set; }

        private FlightId(Guid value)
        {
            Value = value;
        }

        public static FlightId Create(Guid value)
        { 
            return new FlightId(value);
        }
    }
}