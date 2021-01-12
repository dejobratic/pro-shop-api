using ProShop.Core.Models;
using System;

namespace ProShop.Products.Domain.Models
{
    public class ProductReview :
        Entity<Guid>
    {
        public string Title { get; }
        public string Comment { get; }
        public double Rating { get; }
        public DateTime CreatedAt { get; }
        public Customer CreatedBy { get; }

        public ProductReview(
            Guid id,
            string title,
            string comment,
            double rating,
            DateTime createdAt,
            Customer createdBy)
            : base(id)
        {
            Title = title;
            Comment = comment;
            Rating = rating;
            CreatedAt = createdAt;
            CreatedBy = createdBy;
        }
    }
}