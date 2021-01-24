using ProShop.Core.Tests.Unit.Helpers;
using ProShop.Shopping.Contract.Dtos;
using System;

namespace ProShop.Shopping.App.Tests.Unit.Fakes
{
    public static class MockOrderItemDtoBuilder
    {
        public static OrderItemDto Build(
            Guid? id = null,
            Guid? product = null,
            int quantity = 10,
            decimal price = 0.99m)
        {
            return new OrderItemDto
            {
                Id = id ?? GuidProvider.OrderItemId,
                Product = product ?? GuidProvider.ProductId,
                Quantity = quantity,
                Price = price
            };
        }
    }
}