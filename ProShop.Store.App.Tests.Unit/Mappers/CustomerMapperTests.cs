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
    public class CustomerMapperTests
    {
        [TestMethod]
        public void ToDomainModel_maps_contract_customer_to_domain_model()
        {
            CustomerDto customer = MockCustomerDtoBuilder.Build();

            Customer actual = customer.ToDomainModel();
            Customer expected = MockCustomerBuilder.Build();

            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod]
        public void ToContractModel_maps_domain_customer_to_contract_model()
        {
            Customer customer = MockCustomerBuilder.Build();

            CustomerDto actual = customer.ToContractModel();
            CustomerDto expected = MockCustomerDtoBuilder.Build();

            actual.Should().BeEquivalentTo(expected);
        }
    }
}
