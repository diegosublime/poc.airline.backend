namespace airline.backend.reservations.domain.reservation
{
    public sealed record UserId
    {
        public Guid Value { get; private set; }

        private UserId(Guid value)
        {
            Value = value;
        }

        public static UserId Create(Guid value)
        { 
            return new UserId(value);
        }
    }
}