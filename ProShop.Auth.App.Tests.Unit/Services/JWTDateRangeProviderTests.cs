using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProShop.Auth.App.Services;
using ProShop.Auth.Domain.Models;
using System;

namespace ProShop.Auth.App.Tests.Unit.Services
{
    [TestClass]
    [TestCategory("Unit")]
    public class JWTDateRangeProviderTests
    {
        private JWTDateRangeProvider _sut;

        [TestInitialize]
        public void Initialize()
        {
            CreateSut();
        }

        [TestMethod]
        public void Able_to_create_instance()
        {
        }

        [TestMethod]
        public void Provide_provides_date_range()
        {
            DateRange actual = _sut.Provide();
            DateRange expected = new DateRange(
                DateTime.UtcNow,
                DateTime.UtcNow.AddDays(1));

            actual.Should().BeEquivalentTo(expected,
                opt => opt.Using<DateTime>(
                    ctx => ctx.Subject.Should().BeCloseTo(ctx.Expectation, 1000)).WhenTypeIs<DateTime>());
        }

        private void CreateSut()
        {
            _sut = new JWTDateRangeProvider();
        }
    }
}
