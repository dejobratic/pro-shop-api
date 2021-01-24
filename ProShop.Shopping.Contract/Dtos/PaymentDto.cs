using System;

namespace ProShop.Shopping.Contract.Dtos
{
    public class PaymentDto
    {
        public string Method { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime CompletedAt { get; set; }
    }
}
