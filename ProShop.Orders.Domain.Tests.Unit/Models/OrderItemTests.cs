using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProShop.Orders.Domain.Models;
using ProShop.Orders.Domain.Tests.Unit.Fakes;
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
            var expectedProduct = MockProductBuilder.Build();
            var expectedQuantity = 1;
            var expectedPrice = 0.99m;

            var sut = new OrderItem(
                expectedId,
                expectedProduct,
                expectedQuantity,
                expectedPrice);

            sut.Id.Should().Be(expectedId);
            sut.Product.Should().Be(expectedProduct);
            sut.Quantity.Should().Be(expectedQuantity);
            sut.Price.Should().Be(expectedPrice);
        }
    }
}
