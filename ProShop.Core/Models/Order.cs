using System;
using System.Collections.Generic;

namespace ProShop.Core.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public IEnumerable<Product> Items { get; set; }
        public User CreatedBy { get; set; }
    }
}
