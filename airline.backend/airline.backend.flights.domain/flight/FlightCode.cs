namespace airline.backend.flights.domain
{
    /// <summary>
    /// Flight code is a string element confomed by 5 alphanumeric uppercase charracters.
    /// </summary>
    public sealed record FlightCode
    {
        public string Value { get; private set; }

        private FlightCode(string value)
        {
            Value = value;
        }

        public static FlightCode Create(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Flight code is mandatory");
            }

            if (!value.All(char.IsLetterOrDigit) || value.Count() != 5)
            {
                throw new ArgumentException("Flight code invalid format");
            }

            value = value.ToUpper();

            return new FlightCode(value);
        }
    }
}
