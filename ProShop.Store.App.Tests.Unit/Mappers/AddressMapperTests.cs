using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProShop.Store.App.Mappers;
using ProShop.Store.App.Tests.Unit.Fakes;
using ProShop.Store.Contract.Dtos;
using ProShop.Store.Domain.Models;
using ProShop.Store.Domain.Tests.Unit.Fakes;

namespace ProShop.Store.App.Tests.Unit.Mappers
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
