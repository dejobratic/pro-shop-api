using ProShop.Contract.Dtos;
using ProShop.Core.Tests.Unit.Helpers;
using System;

namespace ProShop.Products.App.Tests.Unit.Fakes
{
    public static class MockCustomerDtoBuilder
    {
        public static CustomerDto Build(
            Guid? id = null,
            string firstName = "FirstName",
            string lastName = "LastName")
        {
            return new CustomerDto
            {
                Id = id ?? GuidProvider.UserId,
                FirstName = firstName,
                LastName = lastName
            };
        }
    }
}