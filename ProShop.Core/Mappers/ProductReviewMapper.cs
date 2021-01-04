using ProShop.Contract.Dtos;
using ProShop.Core.Models;

namespace ProShop.Core.Mappers
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
