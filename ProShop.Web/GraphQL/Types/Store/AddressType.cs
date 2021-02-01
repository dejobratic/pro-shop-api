using GraphQL.Types;
using ProShop.Store.Contract.Dtos;

namespace ProShop.Web.GraphQL.Types.Store
{
    public class AddressType :
        ObjectGraphType<AddressDto>
    {
        public AddressType()
        {
            Name = "Address";

            Field(_ => _.StreetLine1).Description("Street line 1.");
            Field(_ => _.StreetLine2).Description("Street line 2.");
            Field(_ => _.City).Description("City.");
            Field(_ => _.StateOrProvince).Description("State or province.");
            Field(_ => _.PostalCode).Description("Postal code.");
            Field(_ => _.Country).Description("Country.");
        }
    }
}
