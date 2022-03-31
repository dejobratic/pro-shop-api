using ProShop.Auth.Domain.Models;
using ProShop.Core.Tests.Unit.Helpers;
using System;
using System.Linq;

namespace ProShop.Auth.Domain.Tests.Unit.Fakes
{
    public static class MockUserBuilder
    {
        public static User Build(
            Guid? id = null,
            string firstName = "FirstName",
            string lastName = "LastName",
            UserCredentials credentials = null,
            bool verified = false,
            params Role[] roles)
        {
            if (!roles.Any())
                roles = new[] { Role.Customer };

            return new User(
                id ?? GuidProvider.UserId,
                firstName,
                lastName,
                credentials ?? MockUserCredentialsBuilder.Build(),
                verified,
                roles);
        }
    }
}