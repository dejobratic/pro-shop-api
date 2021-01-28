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
