using System;

namespace ProShop.Contract.Dtos
{
    public class ProductReviewDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public double Rating { get; set; }
        public DateTime CreatedAt { get; set; }
        public CustomerDto CreatedBy { get; set; }
    }
}