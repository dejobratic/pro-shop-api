using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProShop.Core.Tests.Unit.Helpers;
using ProShop.Shopping.Domain.Models;

namespace ProShop.Shopping.Domain.Tests.Unit.Models
{
    [TestClass]
    [TestCategory("Unit")]
    public class PaymentTests
    {
        [TestMethod]
        public void Able_to_create_instance()
        {
            var expectedMethod = PaymentMethod.PayPal;
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

        [TestMethod]
        public void Able_to_create_instance_with_payment_method_only()
        {
            var expectedMethod = PaymentMethod.PayPal;
            var expectedIsCompleted = false;
            var expectedCompletedAt = DateTimeProvider.MinValue;

            var sut = new Payment(
                expectedMethod);

            sut.Method.Should().Be(expectedMethod);
            sut.IsCompleted.Should().Be(expectedIsCompleted);
            sut.CompletedAt.Should().Be(expectedCompletedAt);
        }
    }
}
