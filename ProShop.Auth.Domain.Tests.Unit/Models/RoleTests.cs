using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProShop.Auth.Domain.Models;

namespace ProShop.Auth.Domain.Tests.Unit.Models
{
    [TestClass]
    [TestCategory("Unit")]
    public class RoleTests
    {
        [TestMethod]
        public void Able_to_create_role()
        {
            var expectedName = "Customer";

            var actual = new Role(
                expectedName);

            actual.Name.Should().Be(expectedName);
        }

        [TestMethod]
        public void Admin_role_has_correct_name()
        {
            Role.Admin.Should().BeEquivalentTo(new Role("Admin"));
        }

        [TestMethod]
        public void Customer_role_has_correct_name()
        {
            Role.Customer.Should().BeEquivalentTo(new Role("Customer"));
        }
    }
}
