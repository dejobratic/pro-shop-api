using ProShop.Core.Tests.Unit.Helpers;
using ProShop.Products.Contract.Dtos;
using System;
using System.Linq;

namespace ProShop.Products.App.Tests.Unit.Fakes
{
    public static class MockProductDtoBuilder
    {
        public static ProductDto Build(
            Guid? id = null,
            string name = "Product",
            string brand = "Brand",
            string category = "Category",
            string description = "Description",
            decimal price = 0.99m,
            int quantityInStock = 100,
            params ProductReviewDto[] reviews)
        {
            if (!reviews.Any())
                reviews = new[] { MockProductReviewDtoBuilder.Build() };

            return new ProductDto
            {
                Id = id ?? GuidProvider.ProductId,
                Name = name,
                Brand = brand,
                Category = category,
                Description = description,
                Price = price,
                QuantityInStock = quantityInStock,
                Reviews = reviews
            };
        }
    }
}
