namespace airline.backend.flights.domain.flight
{
    public record Airport
    {
        public string Code { get; private set; }
        public string City { get; private set; }
        private Airport(string code, string city)
        {
            Code = code;
            City = city;
        }

        public static Airport Create(string code, string city)
        {
            if (string.IsNullOrEmpty(code) || string.IsNullOrEmpty(city))
            {
                throw new ArgumentNullException("Airport city and code are mandatory");
            }

            if (!code.All(char.IsLetter) || code.Count() != 2)
            {
                throw new ArgumentException("Airport code invalid format");
            }

            if (!city.All(char.IsLetter))
            {
                throw new ArgumentException("Airport city invalid format");
            }

            code = code.ToUpper();

            return new Airport(code, city);
        }
    }
}
