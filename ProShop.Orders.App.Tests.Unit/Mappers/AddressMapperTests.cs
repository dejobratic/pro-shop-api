using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProShop.Orders.App.Mappers;
using ProShop.Orders.App.Tests.Unit.Fakes;
using ProShop.Orders.Contract.Dtos;
using ProShop.Orders.Domain.Models;
using ProShop.Orders.Domain.Tests.Unit.Fakes;

namespace ProShop.Orders.App.Tests.Unit.Mappers
{
    [TestClass]
    [TestCategory("Unit")]
    public class AddressMapperTests
    {
        [TestMethod]
        public void ToDomainModel_maps_contract_address_to_domain_model()
        {
            AddressDto address = MockAddressDtoBuilder.Build();

            Address actual = address.ToDomainModel();
            Address expected = MockAddressBuilder.Build();

            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod]
        public void ToContractModel_maps_domain_address_to_contract_model()
        {
            Address address = MockAddressBuilder.Build();

            AddressDto actual = address.ToContractModel();
            AddressDto expected = MockAddressDtoBuilder.Build();

            actual.Should().BeEquivalentTo(expected);
        }
    }
}
