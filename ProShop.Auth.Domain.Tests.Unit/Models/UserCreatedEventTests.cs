using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProShop.Auth.Domain.Models;
using System;

namespace ProShop.Auth.Domain.Tests.Unit.Models
{
    [TestClass]
    [TestCategory("Unit")]
    public class UserCreatedEventTests
    {
        [TestMethod]
        public void Able_to_create_instance()
        {
            var expectedId = Guid.NewGuid();
            var expectedFirstName = "FirstName";
            var expectedLastName = "LastName";

            var sut = new UserCreatedEvent(
                expectedId,
                expectedFirstName,
                expectedLastName);

            sut.Id.Should().Be(expectedId);
            sut.FirstName.Should().Be(expectedFirstName);
            sut.LastName.Should().Be(expectedLastName);
        }
    }
}
