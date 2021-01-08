using ProShop.Core.Models;
using System;

namespace ProShop.Core.Tests.Unit.Fakes
{
    public static class MockUserBuilder
    {
        public static User Build(
            Guid? id = null,
            string firstName = "FirstName",
            string lastName = "LastName",
            Credentials credentials = null)
        {
            return new User(
                id ?? GuidProvider.UserId,
                firstName,
                lastName,
                credentials ?? MockCredentialsBuilder.Build());
        }
    }
}