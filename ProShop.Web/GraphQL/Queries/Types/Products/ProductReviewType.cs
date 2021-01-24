using GraphQL.Types;
using ProShop.Products.Contract.Dtos;

namespace ProShop.Web.GraphQL.Queries.Types.Products
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
