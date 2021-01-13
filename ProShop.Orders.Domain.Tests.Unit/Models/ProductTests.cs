using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProShop.Orders.Domain.Models;
using System;

namespace ProShop.Orders.Domain.Tests.Unit.Models
{
    [TestClass]
    [TestCategory("Unit")]
    public class ProductTests
    {
        [TestMethod]
        public void Able_to_create_instance()
        {
            var expectedId = Guid.NewGuid();
            var expectedName = "Product";

            var sut = new Product(
                expectedId,
                expectedName);

            sut.Id.Should().Be(expectedId);
            sut.Name.Should().Be(expectedName);
        }
    }
}
