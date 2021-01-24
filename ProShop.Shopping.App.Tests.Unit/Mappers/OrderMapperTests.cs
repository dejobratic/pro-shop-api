using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProShop.Shopping.App.Mappers;
using ProShop.Shopping.App.Tests.Unit.Fakes;
using ProShop.Shopping.Contract.Dtos;
using ProShop.Shopping.Domain.Models;
using ProShop.Shopping.Domain.Tests.Unit.Fakes;

namespace ProShop.Shopping.App.Tests.Unit.Mappers
{
    [TestClass]
    [TestCategory("Unit")]
    public class OrderMapperTests
    {
        [TestMethod]
        public void ToDomainModel_maps_contract_order_to_domain_model()
        {
            OrderDto order = MockOrderDtoBuilder.Build();

            Order actual = order.ToDomainModel();
            Order expected = MockOrderBuilder.Build();

            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod]
        public void ToContractModel_maps_domain_order_to_contract_model()
        {
            Order order = MockOrderBuilder.Build();

            OrderDto actual = order.ToContractModel();
            OrderDto expected = MockOrderDtoBuilder.Build();

            actual.Should().BeEquivalentTo(expected);
        }
    }
}
