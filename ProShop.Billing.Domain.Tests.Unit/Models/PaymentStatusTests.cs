using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProShop.Billing.Domain.Models;
using System;

namespace ProShop.Billing.Domain.Tests.Unit.Models
{
    [TestClass]
    [TestCategory("Unit")]
    public class PaymentStatusTests
    {
        [TestMethod]
        public void Able_to_create_instance_with_app_constructor()
        {
            var expectedName = "Created";
            var expectedCreatedAt = DateTime.UtcNow;

            var actual = new PaymentStatus(
                expectedName,
                expectedCreatedAt);

            actual.Id.Should().NotBeEmpty();
            actual.Name.Should().Be(expectedName);
            actual.CreatedAt.Should().Be(expectedCreatedAt);
        }
    }
}
