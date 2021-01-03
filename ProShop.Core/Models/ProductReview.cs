using System;

namespace ProShop.Core.Models
{
    public class ProductReview
    {
        public string Title { get; set; }
        public string Comment { get; set; }
        public double Rating { get; set; }
        public DateTime CreatedAt { get; set; }
        public User CreatedBy { get; set; }
    }
}