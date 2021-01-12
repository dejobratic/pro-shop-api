using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProShop.Orders.Domain.Models;
using ProShop.Orders.Domain.Tests.Unit.Fakes;
using System;

namespace ProShop.Orders.Domain.Tests.Unit.Models
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
            var expectedCustomer = MockCustomerBuilder.Build();

            var sut = new Order(
                expectedId,
                expectedItems,
                expectedCustomer);

            sut.Id.Should().Be(expectedId);
            sut.Items.Should().BeEquivalentTo(expectedItems);
            sut.Customer.Should().Be(expectedCustomer);
        }
    }
}
