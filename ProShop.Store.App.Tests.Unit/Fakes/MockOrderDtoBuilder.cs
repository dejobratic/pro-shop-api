using ProShop.Core.Tests.Unit.Helpers;
using ProShop.Store.Contract.Dtos;
using System;
using System.Linq;

namespace ProShop.Store.App.Tests.Unit.Fakes
{
    public static class MockOrderDtoBuilder
    {
        public static OrderDto Build(
            Guid? id = null,
            AddressDto shippingAddress = null,
            PaymentDto payment = null,
            Guid? customer = null,
            params OrderItemDto[] items)
        {
            if (!items.Any())
                items = new[] { MockOrderItemDtoBuilder.Build() };

            return new OrderDto
            {
                Id = id ?? GuidProvider.OrderId,
                Items = items,
                ShippingAddress = shippingAddress ?? MockAddressDtoBuilder.Build(),
                Payment = payment ?? MockPaymentDtoBuilder.Build(),
                Customer = customer ?? GuidProvider.UserId
            };
        }
    }
}
