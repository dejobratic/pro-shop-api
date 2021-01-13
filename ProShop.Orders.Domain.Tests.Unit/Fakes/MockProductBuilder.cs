using ProShop.Core.Tests.Unit.Helpers;
using ProShop.Orders.Domain.Models;
using System;

namespace ProShop.Orders.Domain.Tests.Unit.Fakes
{
    public static class MockProductBuilder
    {
        public static Product Build(
            Guid? id = null,
            string name = "Product")
        {
            return new Product(
                id ?? GuidProvider.ProductId,
                name);
        }
    }
}
