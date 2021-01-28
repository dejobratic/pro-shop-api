using ProShop.Store.Contract.Dtos;

namespace ProShop.Store.App.Tests.Unit.Fakes
{
    public static class MockAddressDtoBuilder
    {
        public static AddressDto Build(
            string streetLine1 = "StreetLine1",
            string streetLine2 = "StreetLine2",
            string city = "City",
            string stateOrProvince = "StateOrProvince",
            string postalCode = "PostalCode",
            string country = "Country")
        {
            return new AddressDto
            {
                StreetLine1 = streetLine1,
                StreetLine2 = streetLine2,
                City = city,
                StateOrProvince = stateOrProvince,
                PostalCode = postalCode,
                Country = country
            };
        }
    }
}