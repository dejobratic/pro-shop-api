using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProShop.Auth.App.Models;
using ProShop.Auth.App.Services;
using ProShop.Auth.App.Tests.Unit.Fakes;
using ProShop.Auth.Contract.Dtos;
using ProShop.Auth.Domain.Models;
using ProShop.Auth.Domain.Tests.Unit.Fakes;
using System;

namespace ProShop.Auth.App.Tests.Unit.Services
{
    [TestClass]
    [TestCategory("Unit")]
    public class JWTGeneratorTests
    {
        private JWTGenerator _sut;

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
        public void Generate_generates_jwt_token()
        {
            User user = MockUserBuilder.Build();

            TokenDto actual = _sut.Generate(user);
            TokenDto expected = new TokenDto
            {
                Value = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJVc2VySWQiOiI3ODJiNjJmYS1kMjZlLTQ2OWQtOGUxYy1iZWQ3NjY4OWM3MmIiLCJSb2xlcyI6IkN1c3RvbWVyIiwibmJmIjoxNjA5NDU1NjAwLCJleHAiOjE2MDk1NDIwMDAsImlhdCI6MTYwOTQ1NTYwMH0.ZMG-Z1i_CmGGQPn8Isq5q4vU8oZ7Fi4SUuBrddzVe2c",
                Type = "Bearer",
                ExpiresAt = DateTime.Parse("2021-01-02 00:00:00")
            };

            actual.Should().BeEquivalentTo(expected);
        }

        private void CreateSut()
        {
            _sut = new JWTGenerator(
                new JWTSettings 
                { 
                    Secret = "thirty-two-character-long-string" 
                },
                new FakeJWTDateRangeProvider 
                { 
                    Returns = new DateRange(
                        DateTime.Parse("2021-01-01 00:00:00"),
                        DateTime.Parse("2021-01-02 00:00:00"))
                });
        }
    }
}
