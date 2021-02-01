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
        public Guid Customer { get; }

        public Order(
            IEnumerable<OrderItem> items,
            Address shippingAddress,
            Guid customer)
            : this(Guid.NewGuid(), items, shippingAddress, customer)
        {
            AddDomainEvent(new OrderCreatedEvent(Id, items, shippingAddress, customer));
        }

        public Order(
            Guid id,
            IEnumerable<OrderItem> items,
            Address shippingAddress,
            Guid customer)
            : base(id)
        {
            Items = items;
            ShippingAddress = shippingAddress;
            Customer = customer;
        }
    }
}
