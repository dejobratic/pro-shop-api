using System;
using System.Collections.Generic;

namespace ProShop.Orders.Contract.Dtos
{
    public class OrderDto
    {
        public Guid Id { get; set; }
        public IEnumerable<OrderItemDto> Items { get; set; }
    }
}
