using ProShop.Shopping.Domain.Models;

namespace ProShop.Shopping.Domain.Tests.Unit.Fakes
{
    public static class MockAddressBuilder
    {
        public static Address Build(
            string streetLine1 = "StreetLine1",
            string streetLine2 = "StreetLine2",
            string city = "City",
            string stateOrProvince = "StateOrProvince",
            string postalCode = "PostalCode",
            string country = "Country")
        {
            return new Address(
                streetLine1,
                streetLine2,
                city,
                stateOrProvince,
                postalCode,
                country);
        }
    }
}
