using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProShop.Orders.Domain.Models;
using ProShop.Orders.Domain.Tests.Unit.Fakes;
using System;

namespace ProShop.Core.Tests.Unit.Models
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
            var expectedOrders = new[] { MockOrderBuilder.Build() };

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
