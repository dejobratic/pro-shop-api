using ProShop.Orders.Contract.Dtos;
using ProShop.Orders.Domain.Models;

namespace ProShop.Orders.App.Mappers
{
    public static class OrderItemMapper
    {
        public static OrderItemDto ToContractModel(
            this OrderItem item)
        {
            return new OrderItemDto
            {
                Id = item.Id,
                Product = item.Product.ToContractModel(),
                Price = item.Price,
                Quantity = item.Quantity
            };
        }
    }
}
