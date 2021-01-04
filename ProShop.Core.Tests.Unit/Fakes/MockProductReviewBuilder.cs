using ProShop.Core.Models;
using System;

namespace ProShop.Core.Tests.Unit.Fakes
{
    public static class MockProductReviewBuilder
    {
        public static ProductReview Build(
            Guid? id = null,
            string title = "Title",
            string comment = "Comment",
            double rating = 4.5,
            DateTime? createdAt = null,
            User createdBy = null)
        {
            return new ProductReview
            {
                Id = id ?? GuidProvider.ProductReviewId,
                Title = title,
                Comment = comment,
                Rating = rating,
                CreatedAt = createdAt ?? DateTimeProvider.Today,
                CreatedBy = createdBy ?? MockUserBuilder.Build() 
            };
        }
    }
}
