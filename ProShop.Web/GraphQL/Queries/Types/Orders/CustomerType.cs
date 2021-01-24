using GraphQL.Types;
using ProShop.Shopping.Contract.Dtos;

namespace ProShop.Web.GraphQL.Queries.Types.Orders
{
    public class CustomerType :
        ObjectGraphType<CustomerDto>
    {
        public CustomerType()
        {
            Name = "OrderCustomer";

            Field(_ => _.Id).Description("Customer id.");
            Field(_ => _.FirstName).Description("Customer first name.");
            Field(_ => _.LastName).Description("Customer last name.");
            Field<ListGraphType<OrderType>>(nameof(CustomerDto.Orders), "Customer orders.");
        }
    }
}
