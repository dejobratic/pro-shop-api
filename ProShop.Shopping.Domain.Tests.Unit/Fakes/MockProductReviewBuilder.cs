using ProShop.Core.Tests.Unit.Helpers;
using ProShop.Shopping.Domain.Models;
using System;

namespace ProShop.Shopping.Domain.Tests.Unit.Fakes
{
    public static class MockProductReviewBuilder
    {
        public static ProductReview Build(
            Guid? id = null,
            string title = "Title",
            string comment = "Comment",
            double rating = 4.5,
            DateTime? createdAt = null,
            Guid? createdBy = null)
        {
            return new ProductReview(
                id ?? GuidProvider.ProductReviewId,
                title,
                comment,
                rating,
                createdAt ?? DateTimeProvider.Today,
                createdBy ?? GuidProvider.UserId);
        }
    }
}
