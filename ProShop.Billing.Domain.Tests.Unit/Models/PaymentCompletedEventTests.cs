using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProShop.Billing.Domain.Models;
using System;

namespace ProShop.Billing.Domain.Tests.Unit.Models
{
    [TestClass]
    [TestCategory("Unit")]
    public class PaymentCompletedEventTests
    {
        [TestMethod]
        public void Able_to_create_instance()
        {
            var expectedOrderId = Guid.NewGuid();
            var expectedPaidAt = DateTime.UtcNow;

            var actual = new PaymentCompletedEvent(
                expectedOrderId,
                expectedPaidAt);

            actual.OrderId.Should().Be(expectedOrderId);
            actual.PaidAt.Should().Be(expectedPaidAt);
        }
    }
}
