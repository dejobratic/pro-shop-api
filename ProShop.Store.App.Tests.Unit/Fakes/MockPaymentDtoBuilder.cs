using ProShop.Core.Tests.Unit.Helpers;
using ProShop.Store.Contract.Dtos;
using System;

namespace ProShop.Store.App.Tests.Unit.Fakes
{
    public class MockPaymentDtoBuilder
    {
        public static PaymentDto Build(
            string method = "PayPal",
            bool isCompleted = true,
            DateTime? completedAt = null)
        {
            return new PaymentDto
            {
                Method = method,
                IsCompleted = isCompleted,
                CompletedAt = completedAt ?? DateTimeProvider.Today
            };
        }
    }
}