using ProShop.Core.Tests.Unit.Helpers;
using ProShop.Orders.Domain.Models;
using System;

namespace ProShop.Orders.Domain.Tests.Unit.Fakes
{
    public static class MockPaymentBuilder
    {
        public static Payment Build(
            string method = "Method",
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
