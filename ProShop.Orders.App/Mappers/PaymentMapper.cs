using ProShop.Orders.Contract.Dtos;
using ProShop.Orders.Domain.Models;

namespace ProShop.Orders.App.Mappers
{
    public static class PaymentMapper
    {
        public static PaymentDto ToContractModel(
            this Payment payment)
        {
            return new PaymentDto
            {
                Method = payment.Method.ToString(),
                IsCompleted = payment.IsCompleted,
                CompletedAt = payment.CompletedAt
            };
        }
    }
}
