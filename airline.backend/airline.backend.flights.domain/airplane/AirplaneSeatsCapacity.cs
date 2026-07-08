namespace airline.backend.flights.domain
{
    public sealed record AirplaneSeatsCapacity
    {
        public int Value { get; private set; }

        private AirplaneSeatsCapacity(int value)
        {
            Value = value;
        }

        public static AirplaneSeatsCapacity Create(int value)
        { 
            if (value < 1 || value > 900)
            {
                throw new ArgumentException("Invalid number of seats for an airplane");
            }
              
            return new AirplaneSeatsCapacity(value);
        }
    }
}