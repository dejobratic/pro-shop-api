using GraphQL.Types;
using ProShop.Contract.Dtos;

namespace ProShop.Web.GraphQL.Types
{
    public class ProductReviewType :
        ObjectGraphType<ProductReviewDto>
    {
        public ProductReviewType()
        {
            Name = "Review";

            Field(_ => _.Title).Description("Review title.");
            Field(_ => _.Comment).Description("Review comment.");
            Field(_ => _.Rating).Description("Review rating.");
            Field(_ => _.CreatedAt).Description("Review creation date.");
            //Field<ProductReviewType>(nameof(ProductReview.CreatedBy), "Review creator.");
        }
    }
}
