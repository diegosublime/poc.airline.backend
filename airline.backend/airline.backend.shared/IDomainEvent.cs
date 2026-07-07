namespace airline.backend.shared
{
    public interface IDomainEvent
    {
        string EventName { get; }
        DateTime EventRisedTime { get; }
    }
}