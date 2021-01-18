using ProShop.Orders.Contract.Dtos;
using ProShop.Orders.Domain.Models;
using System.Linq;

namespace ProShop.Orders.App.Mappers
{
    public static class OrderMapper
    {
        public static OrderDto ToContractModel(
            this Order order)
        {
            return new OrderDto
            {
                Id = order.Id,
                Items = order.Items.Select(i => i.ToContractModel()),
                ShippingAddress = order.ShippingAddress.ToContractModel(),
                Payment = order.Payment.ToContractModel(),
                Customer = order.Customer.ToContractModel()
            };
        }
    }
}
