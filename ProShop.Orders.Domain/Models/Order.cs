using ProShop.Core.Models;
using System;
using System.Collections.Generic;

namespace ProShop.Orders.Domain.Models
{
    public class Order :
        Entity<Guid>
    {
        public IEnumerable<OrderItem> Items { get; }
        public Customer Customer { get; }

        public Order(
            Guid id,
            IEnumerable<OrderItem> items,
            Customer customer)
            : base(id)
        {
            Items = items;
            Customer = customer;
        }
    }
}
