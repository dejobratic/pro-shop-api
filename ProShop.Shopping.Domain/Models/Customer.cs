using ProShop.Core.Models;
using System;
using System.Collections.Generic;

namespace ProShop.Shopping.Domain.Models
{
    public class Customer :
        AggregateRoot
    {
        public string FirstName { get; }
        public string LastName { get; }
        public IEnumerable<Guid> Orders { get; }

        public Customer(
            Guid id,
            string firstName,
            string lastName,
            IEnumerable<Guid> orders)
            : base(id)
        {
            FirstName = firstName;
            LastName = lastName;
            Orders = orders;
        }
    }
}