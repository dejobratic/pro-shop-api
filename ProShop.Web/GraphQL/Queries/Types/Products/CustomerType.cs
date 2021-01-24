using GraphQL.Types;
using ProShop.Shopping.Contract.Dtos;

namespace ProShop.Web.GraphQL.Queries.Types.Products
{
    public class CustomerType :
        ObjectGraphType<CustomerDto>
    {
        public CustomerType()
        {
            Name = "ProductCustomer";

            Field(_ => _.Id).Description("Customer id.");
            Field(_ => _.FirstName).Description("Customer first name.");
            Field(_ => _.LastName).Description("Customer last name.");
        }
    }
}
