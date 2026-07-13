namespace airline.backend.reservations.domain.reservation
{
    public sealed record ReservationId
    {
        public Guid Value { get; private set; }

        private ReservationId(Guid value)
        {
            Value = value;
        }

        public static ReservationId Create(Guid? value = default)
        {
            value ??= Guid.CreateVersion7();

            return new ReservationId(value.Value);
        }
    }
}