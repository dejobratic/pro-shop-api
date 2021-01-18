using System;

namespace ProShop.Orders.Contract.Dtos
{
    public class PaymentDto
    {
        public string Method { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime CompletedAt { get; set; }
    }
}
