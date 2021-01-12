using ProShop.Core.Tests.Unit.Helpers;
using ProShop.Orders.Domain.Models;
using System;

namespace ProShop.Orders.Domain.Tests.Unit.Fakes
{
    public static class MockOrderItemBuilder
    {
        public static OrderItem Build(
            Guid? id = null,
            int quantity = 10,
            decimal price = 0.99m)
        {
            return new OrderItem(
                id ?? GuidProvider.OrderItemId,
                quantity,
                price);
        }
    }
}
