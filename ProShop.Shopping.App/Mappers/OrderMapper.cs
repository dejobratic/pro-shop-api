using ProShop.Shopping.Contract.Dtos;
using ProShop.Shopping.Domain.Models;
using System.Linq;

namespace ProShop.Shopping.App.Mappers
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
                order.Payment.ToDomainModel(),
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
                Payment = order.Payment.ToContractModel(),
                Customer = order.Customer
            };
        }
    }
}
