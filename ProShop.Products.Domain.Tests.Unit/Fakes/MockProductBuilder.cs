using ProShop.Core.Models;
using ProShop.Core.Tests.Unit.Helpers;
using ProShop.Products.Domain.Models;
using System;
using System.Linq;

namespace ProShop.Products.Domain.Tests.Unit.Fakes
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
