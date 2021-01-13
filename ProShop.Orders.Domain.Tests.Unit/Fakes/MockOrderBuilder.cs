using ProShop.Core.Tests.Unit.Helpers;
using ProShop.Orders.Domain.Models;
using System;
using System.Linq;

namespace ProShop.Orders.Domain.Tests.Unit.Fakes
{
    public static class MockOrderBuilder
    {
        public static Order Build(
            Guid? id = null,
            Address shippingAddress = null,
            Payment payment = null,
            Customer customer = null,
            params OrderItem[] orderItems)
        {
            if (!orderItems.Any())
                orderItems = new[] { MockOrderItemBuilder.Build() };

            return new Order(
                id ?? GuidProvider.OrderId,
                orderItems,
                shippingAddress ?? MockAddressBuilder.Build(),
                payment ?? MockPaymentBuilder.Build(),
                customer ?? MockCustomerBuilder.Build());
        }
    }
}
