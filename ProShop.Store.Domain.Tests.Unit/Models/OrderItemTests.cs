using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProShop.Core.Tests.Unit.Helpers;
using ProShop.Store.Domain.Models;
using System;

namespace ProShop.Store.Domain.Tests.Unit.Models
{
    [TestClass]
    [TestCategory("Unit")]
    public class OrderItemTests
    {
        [TestMethod]
        public void Able_to_create_instance_with_app_constructor()
        {
            var expectedProduct = GuidProvider.ProductId;
            var expectedQuantity = 1;
            var expectedPrice = 0.99m;

            var sut = new OrderItem(
                expectedProduct,
                expectedQuantity,
                expectedPrice);

            sut.Id.Should().NotBeEmpty();
            sut.Product.Should().Be(expectedProduct);
            sut.Quantity.Should().Be(expectedQuantity);
            sut.Price.Should().Be(expectedPrice);
        }

        [TestMethod]
        public void Able_to_create_instance_with_persistence_constructor()
        {
            var expectedId = Guid.NewGuid();
            var expectedProduct = GuidProvider.ProductId;
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
