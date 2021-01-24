using ProShop.Core.Tests.Unit.Helpers;
using ProShop.Shopping.Domain.Models;
using System;

namespace ProShop.Shopping.Domain.Tests.Unit.Fakes
{
    public static class MockPaymentBuilder
    {
        public static Payment Build(
            PaymentMethod method = PaymentMethod.PayPal,
            bool isCompleted = true,
            DateTime? completedAt = null)
        {
            return new Payment(
                method,
                isCompleted,
                completedAt ?? DateTimeProvider.Today);
        }
    }
}
