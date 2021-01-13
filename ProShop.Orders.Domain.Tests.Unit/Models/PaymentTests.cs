using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProShop.Core.Tests.Unit.Helpers;
using ProShop.Orders.Domain.Models;

namespace ProShop.Orders.Domain.Tests.Unit.Models
{
    [TestClass]
    [TestCategory("Unit")]
    public class PaymentTests
    {
        [TestMethod]
        public void Able_to_create_instance()
        {
            var expectedMethod = "Method";
            var expectedIsCompleted = true;
            var expectedCompletedAt = DateTimeProvider.Today;

            var sut = new Payment(
                expectedMethod,
                expectedIsCompleted,
                expectedCompletedAt);

            sut.Method.Should().Be(expectedMethod);
            sut.IsCompleted.Should().Be(expectedIsCompleted);
            sut.CompletedAt.Should().Be(expectedCompletedAt);
        }
    }
}
