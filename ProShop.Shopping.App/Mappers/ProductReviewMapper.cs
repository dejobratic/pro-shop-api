using ProShop.Shopping.Contract.Dtos;
using ProShop.Shopping.Domain.Models;

namespace ProShop.Shopping.App.Mappers
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
                CreatedBy = review.CreatedBy
            };
        }
    }
}
