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
        public IReadOnlyList<Role> Roles => _roles.ToList();

        public User(
            string firstName,
            string lastName,
            UserCredentials credentials)
            : this(Guid.NewGuid(), firstName, lastName, credentials, new[] { Role.Customer })
        {
            AddDomainEvent(new UserCreatedEvent(Id, FirstName, LastName));
        }

        public User(
            Guid id,
            string firstName,
            string lastName,
            UserCredentials credentials,
            IEnumerable<Role> roles)
            : base(id)
        {
            FirstName = firstName;
            LastName = lastName;
            Credentials = credentials;
            _roles = roles.ToHashSet();
        }
    }
}
