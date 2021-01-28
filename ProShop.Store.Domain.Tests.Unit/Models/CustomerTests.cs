using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProShop.Core.Tests.Unit.Helpers;
using ProShop.Store.Domain.Models;
using System;

namespace ProShop.Store.Domain.Tests.Unit.Models
{
    [TestClass]
    [TestCategory("Unit")]
    public class CustomerTests
    {
        [TestMethod]
        public void Able_to_create_instance()
        {
            var expectedId = Guid.NewGuid();
            var expectedFirstName = "FirstName";
            var expectedLastName = "LastName";
            var expectedOrders = new[] { GuidProvider.OrderId };

            var sut = new Customer(
                expectedId,
                expectedFirstName,
                expectedLastName,
                expectedOrders);

            sut.Id.Should().Be(expectedId);
            sut.FirstName.Should().Be(expectedFirstName);
            sut.LastName.Should().Be(expectedLastName);
            sut.Orders.Should().BeEquivalentTo(expectedOrders);
        }
    }
}
