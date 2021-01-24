using ProShop.Orders.Contract.Dtos;
using ProShop.Orders.Domain.Models;

namespace ProShop.Orders.App.Mappers
{
    public static class OrderItemMapper
    {
        public static OrderItem ToDomainModel(
            this OrderItemDto item)
        {
            return new OrderItem(
                item.Id,
                item.Product.ToDomainModel(),
                item.Quantity,
                item.Price);
        }

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
