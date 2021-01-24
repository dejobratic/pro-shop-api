using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProShop.Auth.Domain.Models;
using System;

namespace ProShop.Auth.Domain.Tests.Unit.Models
{
    [TestClass]
    [TestCategory("Unit")]
    public class UserTests
    {
        [TestMethod]
        public void Able_to_create_instance_with_app_constructor()
        {
            var expectedFirstName = "FirstName";
            var expectedLastName = "LastName";
            var expectedCredentials = new UserCredentials(
                "vewso2w2tKmGDKK/dwAUOMQwJ1vXyBIG",
                "1Ql8nRyGoqAa40GRoweHdBdRXz4l3v/O");
            var expectedRoles = new[] { Role.Customer };

            var sut = new User(
                expectedFirstName,
                expectedLastName,
                expectedCredentials);

            sut.Id.Should().NotBeEmpty();
            sut.FirstName.Should().Be(expectedFirstName);
            sut.LastName.Should().Be(expectedLastName);
            sut.Credentials.Should().Be(expectedCredentials);
            sut.Roles.Should().BeEquivalentTo(expectedRoles);
        }

        [TestMethod]
        public void Able_to_create_instance_with_persistence_constructor()
        {
            var expectedId = Guid.NewGuid();
            var expectedFirstName = "FirstName";
            var expectedLastName = "LastName";
            var expectedCredentials = new UserCredentials(
                "vewso2w2tKmGDKK/dwAUOMQwJ1vXyBIG",
                "1Ql8nRyGoqAa40GRoweHdBdRXz4l3v/O");
            var expectedRoles = new[] { Role.Admin };

            var sut = new User(
                expectedId,
                expectedFirstName,
                expectedLastName,
                expectedCredentials,
                expectedRoles);

            sut.Id.Should().Be(expectedId);
            sut.FirstName.Should().Be(expectedFirstName);
            sut.LastName.Should().Be(expectedLastName);
            sut.Credentials.Should().Be(expectedCredentials);
            sut.Roles.Should().BeEquivalentTo(expectedRoles);
        }
    }
}
