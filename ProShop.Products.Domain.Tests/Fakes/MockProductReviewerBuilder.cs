using ProShop.Core.Tests.Unit.Helpers;
using ProShop.Products.Domain.Models;
using System;

namespace ProShop.Products.Domain.Tests.Unit.Fakes
{
    public static class MockProductReviewerBuilder
    {
        public static Customer Build(
            Guid? id = null,
            string firstName = "FirstName",
            string lastName = "LastName")
        {
            return new Customer(
                id ?? GuidProvider.UserId,
                firstName,
                lastName);
        }
    }
}
