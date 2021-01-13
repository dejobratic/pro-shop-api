using ProShop.Core.Models;
using System;

namespace ProShop.Orders.Domain.Models
{
    public class Product :
        Entity<Guid>
    {
        public string Name { get; }

        public Product(
            Guid id,
            string name) 
            : base(id)
        {
            Name = name;
        }
    }
}
