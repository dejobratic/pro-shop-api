using ProShop.Core.Models;
using System;
using System.Collections.Generic;

namespace ProShop.Store.Domain.Models
{
    public class Order :
        AggregateRoot
    {
        public IEnumerable<OrderItem> Items { get; }
        public Address ShippingAddress { get; }
        public Payment Payment { get; }
        public Guid Customer { get; }

        public Order(
            Guid id,
            IEnumerable<OrderItem> items,
            Address shippingAddress,
            Payment payment,
            Guid customer)
            : base(id)
        {
            Items = items;
            ShippingAddress = shippingAddress;
            Payment = payment;
            Customer = customer;
        }
    }
}
