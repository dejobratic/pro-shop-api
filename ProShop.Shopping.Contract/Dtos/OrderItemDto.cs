using System;

namespace ProShop.Shopping.Contract.Dtos
{
    public class OrderItemDto
    {
        public Guid Id { get; set; }
        public Guid Product { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
