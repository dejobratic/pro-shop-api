using ProShop.Core.Models;
using System;
using System.Linq;

namespace ProShop.Core.Tests.Unit.Fakes
{
    public static class MockProductBuilder
    {
        public static Product Build(
            Guid? id = null,
            string name = "Product",
            string brand = "Brand",
            string category = "Category",
            string description = "Description",
            decimal price = 0.99m,
            int quantityInStock = 100,
            params ProductReview[] reviews)
        {
            if (!reviews.Any())
                reviews = new[] { MockProductReviewBuilder.Build() };

            return new Product(
                id ?? GuidProvider.ProductId,
                name,
                brand,
                category,
                description,
                price,
                quantityInStock,
                reviews);
        }
    }
}
