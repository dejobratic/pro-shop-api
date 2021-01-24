using ProShop.Core.Models;
using System;

namespace ProShop.Auth.Domain.Models
{
    public class User :
        Entity<Guid>
    {
        public string FirstName { get; }
        public string LastName { get; }
        public UserCredentials Credentials { get; }

        public User(
            string firstName,
            string lastName,
            UserCredentials credentials)
            : this(Guid.NewGuid(), firstName, lastName, credentials)
        {
        }

        public User(
            Guid id,
            string firstName,
            string lastName,
            UserCredentials credentials)
            : base(id)
        {
            FirstName = firstName;
            LastName = lastName;
            Credentials = credentials;
        }
    }
}
