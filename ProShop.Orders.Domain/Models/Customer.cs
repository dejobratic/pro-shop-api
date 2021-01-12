using ProShop.Core.Models;
using System;
using System.Collections.Generic;

namespace ProShop.Orders.Domain.Models
{
    public class Customer :
        Entity<Guid>
    {
        public string FirstName { get; }
        public string LastName { get; }
        public IEnumerable<Order> Orders { get; }

        public Customer(
            Guid id,
            string firstName,
            string lastName,
            IEnumerable<Order> orders)
            : base(id)
        {
            FirstName = firstName;
            LastName = lastName;
            Orders = orders;
        }
    }
}