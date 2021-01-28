using ProShop.Core.Models;
using System;

namespace ProShop.Store.Domain.Models
{
    public class ProductReview :
        Entity<Guid>
    {
        public string Title { get; }
        public string Comment { get; }
        public double Rating { get; }
        public DateTime CreatedAt { get; }
        public Guid CreatedBy { get; }

        public ProductReview(
            Guid id,
            string title,
            string comment,
            double rating,
            DateTime createdAt,
            Guid createdBy)
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