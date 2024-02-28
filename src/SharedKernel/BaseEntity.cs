using System.Collections.ObjectModel;

namespace SharedKernel;
public abstract class BaseEntity : IBaseEntity
{
    private readonly List<IDomainEvent> _domainEvents = new();

    public IReadOnlyList<IDomainEvent> DomainEvents => _domainEvents.AsReadOnly();

    public IReadOnlyList<IDomainEvent> GetDomainEvents()
    {
        return _domainEvents.ToList();
    }

    public void ClearDomainEvents()
    {
        _domainEvents.Clear();
    }

    public void RaiseEvents(IDomainEvent domainEvent)
    {
        _domainEvents.Add(domainEvent);
    }
}
