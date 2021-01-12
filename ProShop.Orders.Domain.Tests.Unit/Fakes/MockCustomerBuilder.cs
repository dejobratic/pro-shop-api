using ProShop.Core.Tests.Unit.Helpers;
using ProShop.Orders.Domain.Models;
using System;

namespace ProShop.Orders.Domain.Tests.Unit.Fakes
{
    public static class MockCustomerBuilder
    {
        public static Customer Build(
            Guid? id = null,
            string firstName = "FirstName",
            string lastName = "LastName",
            params Order[] orders)
        {
            return new Customer(
                id ?? GuidProvider.UserId,
                firstName,
                lastName,
                orders);
        }
    }
}
