using ProShop.Store.Contract.Dtos;
using ProShop.Store.Domain.Models;
using System.Linq;

namespace ProShop.Store.App.Mappers
{
    public static class OrderMapper
    {
        public static Order ToDomainModel(
            this OrderDto order)
        {
            return new Order(
                order.Id,
                order.Items.Select(i => i.ToDomainModel()),
                order.ShippingAddress.ToDomainModel(),
                order.Customer);
        }

        public static OrderDto ToContractModel(
            this Order order)
        {
            return new OrderDto
            {
                Id = order.Id,
                Items = order.Items.Select(i => i.ToContractModel()),
                ShippingAddress = order.ShippingAddress.ToContractModel(),
                Customer = order.Customer
            };
        }
    }
}
