using ProShop.Auth.Contract.Dtos;
using ProShop.Core.Tests.Unit.Helpers;
using System;

namespace ProShop.Auth.App.Tests.Unit.Fakes
{
    public static class MockTokenDtoBuilder
    {
        public static TokenDto Build(
            string value = "Value",
            string type = "Type",
            DateTimeOffset? expiresAt = null)
        {
            return new TokenDto
            {
                Value = value,
                Type = type,
                ExpiresAt = expiresAt ?? DateTimeProvider.Tomorrow
            };
        }
    }
}
