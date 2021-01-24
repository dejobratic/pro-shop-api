using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProShop.Auth.App.Mappers;
using ProShop.Auth.App.Tests.Unit.Fakes;
using ProShop.Auth.Contract.Dtos;
using ProShop.Auth.Domain.Models;
using ProShop.Auth.Domain.Tests.Unit.Fakes;

namespace ProShop.Auth.App.Tests.Unit.Mappers
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
