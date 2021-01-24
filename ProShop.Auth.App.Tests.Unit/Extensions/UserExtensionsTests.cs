using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProShop.Auth.App.Extensions;
using ProShop.Auth.App.Tests.Unit.Fakes;

namespace ProShop.Auth.App.Tests.Unit.Extensions
{
    [TestClass]
    [TestCategory("Unit")]
    public class UserExtensionsTests
    {
        [TestMethod]
        public void Able_to_add_token_to_user_dto()
        {
            var user = MockUserDtoBuilder.Build();
            var token = MockTokenDtoBuilder.Build();

            var actual = user.WithToken(token);
            var expected = MockUserDtoBuilder.Build(token: token);

            actual.Should().BeEquivalentTo(expected);
        }
    }
}
