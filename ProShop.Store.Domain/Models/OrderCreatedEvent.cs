using ProShop.Core.Models;
using System;
using System.Collections.Generic;

namespace ProShop.Store.Domain.Models
{
    public class OrderCreatedEvent :
        IDomainEvent
    {
        public Guid Id { get;}
        public IEnumerable<OrderItem> Items { get; }
        public Address ShippingAddress { get; }
        public Guid Customer { get; }

        public OrderCreatedEvent(
            Guid id, 
            IEnumerable<OrderItem> items, 
            Address shippingAddress, 
            Guid customer)
        {
            Id = id;
            Items = items;
            ShippingAddress = shippingAddress;
            Customer = customer;
        }

    }
}
