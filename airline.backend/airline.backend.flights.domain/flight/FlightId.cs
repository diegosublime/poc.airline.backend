namespace airline.backend.flights.domain 
{
    public record FlightId
    {
        public Guid Value { get; private set; }

        private FlightId(Guid value)
        {
            Value = value;
        }

        public static FlightId Create(Guid? value = default)
        {
            value ??= Guid.CreateVersion7();

            return new FlightId(value.Value);
        }
    }
}