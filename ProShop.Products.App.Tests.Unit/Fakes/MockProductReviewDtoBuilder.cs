using ProShop.Contract.Dtos;
using ProShop.Core.Tests.Unit.Helpers;
using System;

namespace ProShop.Products.App.Tests.Unit.Fakes
{
    public static class MockProductReviewDtoBuilder
    {
        public static ProductReviewDto Build(
            Guid? id = null,
            string title = "Title",
            string comment = "Comment",
            double rating = 4.5,
            DateTime? createdAt = null,
            CustomerDto createdBy = null)
        {
            return new ProductReviewDto
            {
                Id = id ?? GuidProvider.ProductReviewId,
                Title = title,
                Comment = comment,
                Rating = rating,
                CreatedAt = createdAt ?? DateTimeProvider.Today,
                CreatedBy = createdBy ?? MockCustomerDtoBuilder.Build()
            };
        }
    }
}
