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
            Customer customer = null,
            params OrderItem[] orderItems)
        {
            if (!orderItems.Any())
                orderItems = new[] { MockOrderItemBuilder.Build() };

            return new Order(
                id ?? GuidProvider.OrderId,
                orderItems,
                customer ?? MockCustomerBuilder.Build());
        }
    }
}
