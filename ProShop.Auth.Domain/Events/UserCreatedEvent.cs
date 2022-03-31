using ProShop.Core.Models;
using System;

namespace ProShop.Auth.Domain.Events
{
    public class UserCreatedEvent :
        IDomainEvent
    {
        public Guid Id { get; }
        public string FirstName { get; }
        public string LastName { get; }

        public UserCreatedEvent(
            Guid id,
            string firstName,
            string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
