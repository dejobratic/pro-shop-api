using System;
using System.Collections.Generic;

namespace ProShop.Store.Contract.Dtos
{
    public class OrderDto
    {
        public Guid Id { get; set; }
        public IEnumerable<OrderItemDto> Items { get; set; }
        public AddressDto ShippingAddress { get; set; }
        public PaymentDto Payment { get; set; }
        public Guid Customer { get; set; }
    }
}
