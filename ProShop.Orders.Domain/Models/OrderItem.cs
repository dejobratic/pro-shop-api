using ProShop.Core.Models;
using System;

namespace ProShop.Orders.Domain.Models
{
    public class OrderItem :
        Entity<Guid>
    {
        public int Quantity { get; }
        public decimal Price { get; }

        public OrderItem(
            Guid id,
            int quantity,
            decimal price)
            : base(id)
        {
            Quantity = quantity;
            Price = price;
        }

    }
}
