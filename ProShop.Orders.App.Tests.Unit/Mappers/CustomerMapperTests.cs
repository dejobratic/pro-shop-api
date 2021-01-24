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
