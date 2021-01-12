using ProShop.Core.Models;
using System;
using System.Collections.Generic;

namespace ProShop.Products.Domain.Models
{
    public class Product :
        Entity<Guid>
    {
        public string Name { get; }
        public string Brand { get; }
        public string Category { get; }
        public string Description { get; }
        public decimal Price { get; }
        public int QuantityInStock { get; }
        public IEnumerable<ProductReview> Reviews { get; }

        public Product(
            string name,
            string brand,
            string category,
            string description,
            decimal price,
            int quantityInStock,
            IEnumerable<ProductReview> reviews)
            : this(Guid.NewGuid(), name, brand, category, description, price, quantityInStock, reviews)
        {
            Name = name;
            Brand = brand;
            Category = category;
            Description = description;
            Price = price;
            QuantityInStock = quantityInStock;
            Reviews = reviews;
        }

        public Product(
            Guid id,
            string name,
            string brand,
            string category,
            string description,
            decimal price,
            int quantityInStock,
            IEnumerable<ProductReview> reviews)
            : base(id)
        {
            Name = name;
            Brand = brand;
            Category = category;
            Description = description;
            Price = price;
            QuantityInStock = quantityInStock;
            Reviews = reviews;
        }
    }
}
