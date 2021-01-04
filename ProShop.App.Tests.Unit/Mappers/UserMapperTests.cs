using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProShop.App.Mappers;
using ProShop.App.Tests.Unit.Fakes;
using ProShop.Contract.Dtos;
using ProShop.Core.Models;
using ProShop.Core.Tests.Unit.Fakes;

namespace ProShop.Core.Tests.Unit.Mappers
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
