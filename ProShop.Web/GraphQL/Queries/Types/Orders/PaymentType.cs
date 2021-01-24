using GraphQL.Types;
using ProShop.Orders.Contract.Dtos;

namespace ProShop.Web.GraphQL.Queries.Types.Orders
{
    public class PaymentType :
        ObjectGraphType<PaymentDto>
    {
        public PaymentType()
        {
            Name = "Payment";

            Field(_ => _.Method).Description("Payment method.");
            Field(_ => _.IsCompleted).Description("Payment completed status.");
            Field(_ => _.CompletedAt).Description("Payment completed date.");
        }
    }
}
