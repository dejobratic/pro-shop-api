using ProShop.Core.Tests.Unit.Helpers;
using ProShop.Orders.Contract.Dtos;
using System;

namespace ProShop.Orders.App.Tests.Unit.Fakes
{
    public static class MockCustomerDtoBuilder
    {
        public static CustomerDto Build(
            Guid? id = null,
            string firstName = "FirstName",
            string lastName = "LastName",
            params OrderDto[] orders)
        {
            return new CustomerDto
            {
                Id = id ?? GuidProvider.UserId,
                FirstName = firstName,
                LastName = lastName,
                Orders = orders
            };
        }
    }
}