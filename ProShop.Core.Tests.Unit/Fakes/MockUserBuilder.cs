using ProShop.Core.Models;
using System;

namespace ProShop.Core.Tests.Unit.Fakes
{
    public static class MockUserBuilder
    {
        public static User Build(
            Guid? id = null,
            string firstName = "FirstName",
            string lastName = "LastName")
        {
            return new User
            {
                Id = id ?? GuidProvider.UserId,
                FirstName = firstName,
                LastName = lastName
            };
        }
    }
}