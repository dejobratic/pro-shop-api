using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProShop.Auth.Domain.Events;
using System;

namespace ProShop.Auth.Domain.Tests.Unit.Events
{
    [TestClass]
    [TestCategory("Unit")]
    public class UserVerifiedEventTests
    {
        [TestMethod]
        public void Able_to_create_instance()
        {
            var expectedId = Guid.NewGuid();
            var expectedVerifiedAt = DateTime.UtcNow;

            var sut = new UserVerifiedEvent(
                expectedId,
                expectedVerifiedAt);

            sut.Id.Should().Be(expectedId);
            sut.VerifiedAt.Should().Be(expectedVerifiedAt);
        }
    }
}
