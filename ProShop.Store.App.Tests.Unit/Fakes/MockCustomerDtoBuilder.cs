using ProShop.Core.Tests.Unit.Helpers;
using ProShop.Store.Contract.Dtos;
using System;

namespace ProShop.Store.App.Tests.Unit.Fakes
{
    public static class MockCustomerDtoBuilder
    {
        public static CustomerDto Build(
            Guid? id = null,
            string firstName = "FirstName",
            string lastName = "LastName",
            params Guid[] orders)
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