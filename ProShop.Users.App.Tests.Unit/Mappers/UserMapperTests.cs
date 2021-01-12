using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProShop.Contract.Dtos;
using ProShop.Users.App.Mappers;
using ProShop.Users.App.Tests.Unit.Fakes;
using ProShop.Users.Domain.Models;
using ProShop.Users.Domain.Tests.Unit.Fakes;

namespace ProShop.Users.App.Tests.Unit.Mappers
{
    [TestClass]
    [TestCategory("Unit")]
    public class UserMapperTests
    {
        [TestMethod]
        public void ToContractModel_maps_domain_user_to_contract_model()
        {
            User user = MockUserBuilder.Build();

            UserDto actual = user.ToContractModel();
            UserDto expected = MockUserDtoBuilder.Build();

            actual.Should().BeEquivalentTo(expected);
        }
    }
}
