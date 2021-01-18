using GraphQL.Types;
using ProShop.Products.Contract.Dtos;

namespace ProShop.Web.GraphQL.Types.Products
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
