using ProShop.Core.Models;
using System;

namespace ProShop.Orders.Domain.Models
{
    public class OrderItem :
        Entity<Guid>
    {
        public Product Product { get; }
        public int Quantity { get; }
        public decimal Price { get; }

        public OrderItem(
            Guid id,
            Product product,
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
