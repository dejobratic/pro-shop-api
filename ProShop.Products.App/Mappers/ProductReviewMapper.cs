using ProShop.Contract.Dtos;
using ProShop.Products.App.Mappers;
using ProShop.Products.Domain.Models;

namespace ProShop.Products.App.Mappers
{
    public static class ProductReviewMapper
    {
        public static ProductReviewDto ToContractModel(
            this ProductReview review)
        {
            return new ProductReviewDto
            {
                Id = review.Id,
                Title = review.Title,
                Comment = review.Comment,
                Rating = review.Rating,
                CreatedAt = review.CreatedAt,
                CreatedBy = review.CreatedBy.ToContractModel()
            };
        }
    }
}
