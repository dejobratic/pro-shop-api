using ProShop.Core.Models;
using System;

namespace ProShop.Auth.Domain.Events
{
    public class UserVerifiedEvent :
        IDomainEvent
    {
        public Guid Id { get; }
        public DateTime VerifiedAt { get; }

        public UserVerifiedEvent(
            Guid id,
            DateTime verifiedAt)
        {
            Id = id;
            VerifiedAt = verifiedAt;
        }
    }
}
