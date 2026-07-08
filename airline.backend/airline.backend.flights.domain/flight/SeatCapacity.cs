namespace airline.backend.flights.domain
{
    public class SeatCapacity
    {
        public int Value { get; private set; }

        private SeatCapacity(int value)
        {
            Value = value;
        }

        public static SeatCapacity Create(int value)
        {
            if (value < 1 || value > 900)
            {
                throw new ArgumentException("Invalid number of seats for an airplane");
            }

            return new SeatCapacity(value);
        } 
    }
}