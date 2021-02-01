using ProShop.Core.Models;
using System;

namespace ProShop.Store.Domain.Models
{
    public class OrderItem :
        Entity<Guid>
    {
        public Guid Product { get; }
        public int Quantity { get; }
        public decimal Price { get; }

        public OrderItem(
            Guid product,
            int quantity, 
            decimal price)
            : this(Guid.NewGuid(), product, quantity, price)
        {
        }

        public OrderItem(
            Guid id,
            Guid product,
            int quantity,
            decimal price)
            : base(id)
        {
            Product = product;
            Quantity = quantity;
            Price = price;
        }
    }
}
