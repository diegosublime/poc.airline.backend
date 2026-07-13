namespace airline.backend.reservations.domain.reservation
{
    public sealed record Money
    {
        public string Currency { get; private set; }
        public decimal Value { get; private set; }

        private Money(decimal value, string currency)
        {
            ArgumentOutOfRangeException.ThrowIfNegative(value); 
            Value = value;
            Currency = currency;
        }

        public static Money CreateUSD(decimal value)
        {
            return new Money(value, "USD");
        }

        public static Money CreateMXN(decimal value)
        {
            return new Money(value, "MXN");
        }
    }
}