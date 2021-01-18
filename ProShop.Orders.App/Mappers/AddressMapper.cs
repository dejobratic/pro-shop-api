using ProShop.Orders.Contract.Dtos;
using ProShop.Orders.Domain.Models;

namespace ProShop.Orders.App.Mappers
{
    public static class AddressMapper
    {
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
