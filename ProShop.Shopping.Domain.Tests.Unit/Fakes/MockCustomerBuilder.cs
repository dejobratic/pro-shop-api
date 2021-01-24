using ProShop.Core.Tests.Unit.Helpers;
using ProShop.Shopping.Domain.Models;
using System;

namespace ProShop.Shopping.Domain.Tests.Unit.Fakes
{
    public static class MockCustomerBuilder
    {
        public static Customer Build(
            Guid? id = null,
            string firstName = "FirstName",
            string lastName = "LastName",
            params Guid[] orders)
        {
            return new Customer(
                id ?? GuidProvider.UserId,
                firstName,
                lastName,
                orders);
        }
    }
}
