using ProShop.Core.Models;
using System;

namespace ProShop.Products.Domain.Models
{
    public class Customer :
        Entity<Guid>
    {
        public string FirstName { get; }
        public string LastName { get; }
        public Customer(
            Guid id,
            string firstName,
            string lastName)
            : base(id)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
