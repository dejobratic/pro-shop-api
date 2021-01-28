using ProShop.Core.Tests.Unit.Helpers;
using ProShop.Store.Contract.Dtos;
using System;

namespace ProShop.Store.App.Tests.Unit.Fakes
{
    public static class MockProductReviewDtoBuilder
    {
        public static ProductReviewDto Build(
            Guid? id = null,
            string title = "Title",
            string comment = "Comment",
            double rating = 4.5,
            DateTime? createdAt = null,
            Guid? createdBy = null)
        {
            return new ProductReviewDto
            {
                Id = id ?? GuidProvider.ProductReviewId,
                Title = title,
                Comment = comment,
                Rating = rating,
                CreatedAt = createdAt ?? DateTimeProvider.Today,
                CreatedBy = createdBy ?? GuidProvider.UserId
            };
        }
    }
}
