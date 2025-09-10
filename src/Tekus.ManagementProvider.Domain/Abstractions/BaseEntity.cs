namespace Tekus.ManagementProvider.Domain.Abstractions
{
    public abstract class BaseEntity
    {
        public Guid Id { get; init; }
        public DateTime CreatedAt { get; private set; }
        public DateTime? UpdatedAt { get; private set; }

        public bool IsActive { get; protected set; }
        protected BaseEntity(Guid id)
        {
            Id = id;
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }
        private List<IDomainEvent> _domainEvents = new();

        public void ClearDomainEvents()
        {
            _domainEvents.Clear();
        }

        protected void RaiseDomainEvent(IDomainEvent domainEvent)
        {
            _domainEvents.Add(domainEvent);
        }


    }
}
