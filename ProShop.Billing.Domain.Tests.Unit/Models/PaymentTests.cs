using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProShop.Billing.Domain.Models;
using System;
using System.Linq;

namespace ProShop.Billing.Domain.Tests.Unit.Models
{
    [TestClass]
    [TestCategory("Unit")]
    public class PaymentTests
    {
        [TestMethod]
        public void Able_to_create_instance()
        {
            var expectedOrderId = Guid.NewGuid();
            var expectedMethod = "Method";
            var expectedAmount = 10m;
            var expectedCreatedAt = DateTime.UtcNow;

            var actual = new Payment(
                expectedOrderId,
                expectedMethod,
                expectedAmount,
                expectedCreatedAt);

            actual.Id.Should().NotBeEmpty();
            actual.OrderId.Should().Be(expectedOrderId);
            actual.Method.Should().Be(expectedMethod);
            actual.Amount.Should().Be(expectedAmount);

            actual.Statuses.Should().HaveCount(1);
            actual.Statuses.Single().Name.Should().Be("Pending");
            actual.Statuses.Single().CreatedAt.Should().Be(expectedCreatedAt);
        }

        [TestMethod]
        public void Able_to_complete_payment()
        {
            var actual = new Payment(
                Guid.NewGuid(),
                "Method",
                10m,
                DateTime.UtcNow);

            var expectedPaidAt = DateTime.UtcNow;
            actual.Pay(expectedPaidAt);

            actual.Statuses.Should().HaveCount(2);
            actual.Statuses.Last().Name.Should().Be("Completed");
            actual.Statuses.Last().CreatedAt.Should().Be(expectedPaidAt);
        }
    }
}
