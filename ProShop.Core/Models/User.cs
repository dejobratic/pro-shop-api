using System;

namespace ProShop.Core.Models
{
    public class User :
        Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Credentials Credentials { get; set; }

        public User(
            string firstName,
            string lastName,
            Credentials credentials)
            : this(Guid.NewGuid(), firstName, lastName, credentials)
        {
        }

        public User(
            Guid id,
            string firstName, 
            string lastName,
            Credentials credentials)
            : base(id)
        {
            FirstName = firstName;
            LastName = lastName;
            Credentials = credentials;
        }
    }
}
