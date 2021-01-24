using ProShop.Core.Tests.Unit.Helpers;
using ProShop.Shopping.Contract.Dtos;
using System;

namespace ProShop.Shopping.App.Tests.Unit.Fakes
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