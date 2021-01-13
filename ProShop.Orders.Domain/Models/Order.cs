using ProShop.Core.Models;
using System;
using System.Collections.Generic;

namespace ProShop.Orders.Domain.Models
{
    public class Order :
        Entity<Guid>
    {
        public IEnumerable<OrderItem> Items { get; }
        public Address ShippingAddress { get; }
        public Payment Payment { get; }
        public Customer Customer { get; }

        public Order(
            Guid id,
            IEnumerable<OrderItem> items,
            Address shippingAddress,
            Payment payment,
            Customer customer)
            : base(id)
        {
            Items = items;
            ShippingAddress = shippingAddress;
            Payment = payment;
            Customer = customer;
        }
    }
}
