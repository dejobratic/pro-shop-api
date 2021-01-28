using ProShop.Core.Tests.Unit.Helpers;
using ProShop.Store.Domain.Models;
using System;
using System.Linq;

namespace ProShop.Store.Domain.Tests.Unit.Fakes
{
    public static class MockOrderBuilder
    {
        public static Order Build(
            Guid? id = null,
            Address shippingAddress = null,
            Payment payment = null,
            Guid? customer = null,
            params OrderItem[] orderItems)
        {
            if (!orderItems.Any())
                orderItems = new[] { MockOrderItemBuilder.Build() };

            return new Order(
                id ?? GuidProvider.OrderId,
                orderItems,
                shippingAddress ?? MockAddressBuilder.Build(),
                payment ?? MockPaymentBuilder.Build(),
                customer ?? GuidProvider.UserId);
        }
    }
}
