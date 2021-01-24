using ProShop.Core.Tests.Unit.Helpers;
using ProShop.Auth.Domain.Models;
using System;

namespace ProShop.Auth.Domain.Tests.Unit.Fakes
{
    public static class MockUserBuilder
    {
        public static User Build(
            Guid? id = null,
            string firstName = "FirstName",
            string lastName = "LastName",
            UserCredentials credentials = null)
        {
            return new User(
                id ?? GuidProvider.UserId,
                firstName,
                lastName,
                credentials ?? MockUserCredentialsBuilder.Build());
        }
    }
}