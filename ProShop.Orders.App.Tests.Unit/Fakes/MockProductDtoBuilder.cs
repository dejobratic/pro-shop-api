using ProShop.Core.Tests.Unit.Helpers;
using ProShop.Orders.Contract.Dtos;
using System;

namespace ProShop.Orders.App.Tests.Unit.Fakes
{
    public static class MockProductDtoBuilder
    {
        public static ProductDto Build(
            Guid? id = null,
            string name = "Product")
        {
            return new ProductDto
            {
                Id = id ?? GuidProvider.ProductId,
                Name = name
            };
        }
    }
}