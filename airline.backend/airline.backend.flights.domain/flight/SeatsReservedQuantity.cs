namespace airline.backend.flights.domain
{
    public class SeatsReservedQuantity
    {
        public int Value { get; private set; }

        private SeatsReservedQuantity(int value)
        {
            Value = value;
        }

        public static SeatsReservedQuantity Create(int value = 0)
        {
            if (value < 0 || value > 900)
            {
                throw new ArgumentException("Invalid number of reserved seats for a flight");
            }

            return new SeatsReservedQuantity(value);
        }
    }
}