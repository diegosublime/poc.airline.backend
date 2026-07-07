namespace airline.backend.shared
{
    public abstract class AggregateRoot<T>
    {
        private List<IDomainEvent> _domainEvents;

        public T Id { get; protected set; }
        public IReadOnlyList<IDomainEvent> DomainEvents
        {
            get
            {
                return _domainEvents.AsReadOnly();
            }
        }

        protected AggregateRoot(T id)
        {
            Id = id;
            _domainEvents = [];
        }

        protected void RiseDomainEvent(IDomainEvent domainEvent)
        {
            _domainEvents.Add(domainEvent);
        }

        protected void ClearDomainEvents()
        {
            _domainEvents.Clear();
        }
    }
}
