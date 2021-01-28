using ProShop.Core.Tests.Unit.Helpers;
using ProShop.Store.Domain.Models;
using System;

namespace ProShop.Store.Domain.Tests.Unit.Fakes
{
    public static class MockOrderItemBuilder
    {
        public static OrderItem Build(
            Guid? id = null,
            Guid? product = null,
            int quantity = 10,
            decimal price = 0.99m)
        {
            return new OrderItem(
                id ?? GuidProvider.OrderItemId,
                product ?? GuidProvider.ProductId,
                quantity,
                price);
        }
    }
}
