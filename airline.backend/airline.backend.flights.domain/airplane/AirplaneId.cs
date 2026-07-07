namespace airline.backend.flights.domain 
{
    public sealed record AirplaneId
    {
        public Guid Value { get; private set; }

        private AirplaneId(Guid value)
        {
            Value = value;
        }

        public static AirplaneId Create(Guid? value = default)
        {
            value ??= Guid.CreateVersion7();

            return new AirplaneId(value.Value);
        }
    }
}