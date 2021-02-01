using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProShop.Core.Tests.Unit.Helpers;
using ProShop.Store.Domain.Models;
using ProShop.Store.Domain.Tests.Unit.Fakes;
using System;

namespace ProShop.Store.Domain.Tests.Unit.Models
{
    [TestClass]
    [TestCategory("Unit")]
    public class OrderTests
    {
        [TestMethod]
        public void Able_to_create_instance_with_app_constructor()
        {
            var expectedItems = new[] { MockOrderItemBuilder.Build() };
            var expectedShippingAddress = MockAddressBuilder.Build();
            var expectedCustomer = GuidProvider.UserId;

            var sut = new Order(
                expectedItems,
                expectedShippingAddress,
                expectedCustomer);

            sut.Id.Should().NotBeEmpty();
            sut.Items.Should().BeEquivalentTo(expectedItems);
            sut.ShippingAddress.Should().BeEquivalentTo(expectedShippingAddress);
            sut.Customer.Should().Be(expectedCustomer);
        }

        [TestMethod]
        public void Able_to_create_instance_with_persistence_constructor()
        {
            var expectedId = Guid.NewGuid();
            var expectedItems = new[] { MockOrderItemBuilder.Build() };
            var expectedShippingAddress = MockAddressBuilder.Build();
            var expectedCustomer = GuidProvider.UserId;

            var sut = new Order(
                expectedId,
                expectedItems,
                expectedShippingAddress,
                expectedCustomer);

            sut.Id.Should().Be(expectedId);
            sut.Items.Should().BeEquivalentTo(expectedItems);
            sut.ShippingAddress.Should().BeEquivalentTo(expectedShippingAddress);
            sut.Customer.Should().Be(expectedCustomer);
        }
    }
}
