using System;
using System.Collections.Generic;

namespace ProShop.Core.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public IEnumerable<ProductReview> Reviews { get; set; }
    }
}
