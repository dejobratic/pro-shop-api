using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProShop.Core.Tests.Unit.Helpers;
using ProShop.Shopping.Domain.Models;
using ProShop.Shopping.Domain.Tests.Unit.Fakes;
using System;

namespace ProShop.Shopping.Domain.Tests.Unit.Models
{
    [TestClass]
    [TestCategory("Unit")]
    public class OrderTests
    {
        [TestMethod]
        public void Able_to_create_instance()
        {
            var expectedId = Guid.NewGuid();
            var expectedItems = new[] { MockOrderItemBuilder.Build() };
            var expectedShippingAddress = MockAddressBuilder.Build();
            var expectedPyment = MockPaymentBuilder.Build();
            var expectedCustomer = GuidProvider.UserId;

            var sut = new Order(
                expectedId,
                expectedItems,
                expectedShippingAddress,
                expectedPyment,
                expectedCustomer);

            sut.Id.Should().Be(expectedId);
            sut.Items.Should().BeEquivalentTo(expectedItems);
            sut.ShippingAddress.Should().BeEquivalentTo(expectedShippingAddress);
            sut.Payment.Should().BeEquivalentTo(expectedPyment);
            sut.Customer.Should().Be(expectedCustomer);
        }
    }
}
