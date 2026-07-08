namespace airline.backend.flights.domain
{
    public sealed record AirplaneModel
    {
        public string Value { get; private set; }

        private AirplaneModel(string value)
        {
            Value = value;
        }

        public static AirplaneModel Create(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Airplane model is mandatory");
            }

            if (!value.All(char.IsLetterOrDigit) || value.Count() > 12)
            {
                throw new ArgumentException("Airplane model invalid format");
            }

            value = value.ToUpper();

            return new AirplaneModel(value);
        }
    }
}