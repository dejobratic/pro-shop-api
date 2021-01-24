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
    public class OrderItemMapperTests
    {
        [TestMethod]
        public void ToDomainModel_maps_contract_order_item_to_domain_model()
        {
            OrderItemDto item = MockOrderItemDtoBuilder.Build();

            OrderItem actual = item.ToDomainModel();
            OrderItem expected = MockOrderItemBuilder.Build();

            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod]
        public void ToContractModel_maps_domain_order_item_to_contract_model()
        {
            OrderItem item = MockOrderItemBuilder.Build();

            OrderItemDto actual = item.ToContractModel();
            OrderItemDto expected = MockOrderItemDtoBuilder.Build();

            actual.Should().BeEquivalentTo(expected);
        }
    }
}
