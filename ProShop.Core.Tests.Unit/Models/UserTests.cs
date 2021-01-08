using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProShop.Core.Models;
using System;

namespace ProShop.Core.Tests.Unit.Models
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
            var expectedCredentials = new Credentials("", "");

            var sut = new User(
                expectedFirstName,
                expectedLastName,
                expectedCredentials);

            sut.Id.Should().NotBeEmpty();
            sut.FirstName.Should().Be(expectedFirstName);
            sut.LastName.Should().Be(expectedLastName);
            sut.Credentials.Should().Be(expectedCredentials);
        }

        [TestMethod]
        public void Able_to_create_instance_with_persistence_constructor()
        {
            var expectedId = Guid.NewGuid();
            var expectedFirstName = "FirstName";
            var expectedLastName = "LastName";
            var expectedCredentials = new Credentials("", "");

            var sut = new User(
                expectedId,
                expectedFirstName,
                expectedLastName,
                expectedCredentials);

            sut.Id.Should().Be(expectedId);
            sut.FirstName.Should().Be(expectedFirstName);
            sut.LastName.Should().Be(expectedLastName);
            sut.Credentials.Should().Be(expectedCredentials);
        }
    }
}
