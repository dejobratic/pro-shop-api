using System;
using System.Collections.Generic;

namespace ProShop.Core.Models
{
    public class AggregateRoot :
        Entity<Guid>
    {
        private readonly List<IDomainEvent> _domainEvents;
        public IReadOnlyList<IDomainEvent> DomainEvents => _domainEvents.AsReadOnly();

        public AggregateRoot(Guid id)
            : base(id)
        {
            _domainEvents = new List<IDomainEvent>();
        }

        public void AddDomainEvent(IDomainEvent domainEvent)
            => _domainEvents.Add(domainEvent);

        public void ClearDomainEvents()
            => _domainEvents.Clear();
    }
}
