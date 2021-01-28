using ProShop.Store.Contract.Dtos;
using ProShop.Store.Domain.Models;

namespace ProShop.Store.App.Mappers
{
    public static class AddressMapper
    {
        public static Address ToDomainModel(
            this AddressDto address)
        {
            return new Address(
                address.StreetLine1,
                address.StreetLine2,
                address.City,
                address.StateOrProvince,
                address.PostalCode,
                address.Country);
        }

        public static AddressDto ToContractModel(
            this Address address)
        {
            return new AddressDto
            {
                StreetLine1 = address.StreetLine1,
                StreetLine2 = address.StreetLine2,
                City = address.City,
                StateOrProvince = address.StateOrProvince,
                PostalCode = address.PostalCode,
                Country = address.Country
            };
        }
    }
}
