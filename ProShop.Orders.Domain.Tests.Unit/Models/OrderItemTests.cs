using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProShop.Orders.Domain.Models;
using System;

namespace ProShop.Core.Tests.Unit.Models
{
    [TestClass]
    [TestCategory("Unit")]
    public class OrderItemTests
    {
        [TestMethod]
        public void Able_to_create_instance()
        {
            var expectedId = Guid.NewGuid();
            var expectedQuantity = 1;
            var expectedPrice = 0.99m;

            var sut = new OrderItem(
                expectedId,
                expectedQuantity,
                expectedPrice);

            sut.Id.Should().Be(expectedId);
            sut.Quantity.Should().Be(expectedQuantity);
            sut.Price.Should().Be(expectedPrice);
        }
    }
}
