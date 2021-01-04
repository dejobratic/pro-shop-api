using ProShop.Contract.Dtos;
using ProShop.Core.Tests.Unit.Fakes;
using System;

namespace ProShop.App.Tests.Unit.Fakes
{
    public static class MockProductReviewDtoBuilder
    {
        public static ProductReviewDto Build(
            Guid? id = null,
            string title = "Title",
            string comment = "Comment",
            double rating = 4.5,
            DateTime? createdAt = null,
            UserDto createdBy = null)
        {
            return new ProductReviewDto
            {
                Id = id ?? GuidProvider.ProductReviewId,
                Title = title,
                Comment = comment,
                Rating = rating,
                CreatedAt = createdAt ?? DateTimeProvider.Today,
                CreatedBy = createdBy ?? MockUserDtoBuilder.Build()
            };
        }
    }
}
