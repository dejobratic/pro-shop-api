using ProShop.Store.Contract.Dtos;
using ProShop.Store.Domain.Models;

namespace ProShop.Store.App.Mappers
{
    public static class OrderItemMapper
    {
        public static OrderItem ToDomainModel(
            this OrderItemDto item)
        {
            return new OrderItem(
                item.Id,
                item.Product,
                item.Quantity,
                item.Price);
        }

        public static OrderItemDto ToContractModel(
            this OrderItem item)
        {
            return new OrderItemDto
            {
                Id = item.Id,
                Product = item.Product,
                Price = item.Price,
                Quantity = item.Quantity
            };
        }
    }
}
