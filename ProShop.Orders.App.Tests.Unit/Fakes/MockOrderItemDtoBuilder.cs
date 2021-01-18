using ProShop.Core.Tests.Unit.Helpers;
using ProShop.Orders.Contract.Dtos;
using System;

namespace ProShop.Orders.App.Tests.Unit.Fakes
{
    public static class MockOrderItemDtoBuilder
    {
        public static OrderItemDto Build(
            Guid? id = null,
            ProductDto product = null,
            int quantity = 10,
            decimal price = 0.99m)
        {
            return new OrderItemDto
            {
                Id = id ?? GuidProvider.OrderItemId,
                Product = product ?? MockProductDtoBuilder.Build(),
                Quantity = quantity,
                Price = price
            };
        }
    }
}