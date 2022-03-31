using ProShop.Auth.Domain.Events;
using ProShop.Auth.Domain.Exceptions;
using ProShop.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProShop.Auth.Domain.Models
{
    public class User :
        AggregateRoot
    {
        private readonly HashSet<Role> _roles;

        public string FirstName { get; }
        public string LastName { get; }
        public UserCredentials Credentials { get; }
        public bool Verified { get; private set; }
        public IReadOnlyList<Role> Roles => _roles.ToList();

        public User(
            string firstName,
            string lastName,
            UserCredentials credentials)
            : this(Guid.NewGuid(), firstName, lastName, credentials, false, new[] { Role.Customer })
        {
            AddDomainEvent(new UserCreatedEvent(Id, FirstName, LastName));
        }

        public User(
            Guid id,
            string firstName,
            string lastName,
            UserCredentials credentials,
            bool verified,
            IEnumerable<Role> roles)
            : base(id)
        {
            FirstName = firstName;
            LastName = lastName;
            Credentials = credentials;
            Verified = verified;
            _roles = roles.ToHashSet();
        }

        public void Verify()
        {
            if (Verified)
                throw new UserAlreadyVerifiedException();

            Verified = true;
            AddDomainEvent(new UserVerifiedEvent(Id, DateTime.UtcNow));
        }
    }
}
