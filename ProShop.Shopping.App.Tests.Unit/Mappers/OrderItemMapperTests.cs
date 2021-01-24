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
