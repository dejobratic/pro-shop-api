using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProShop.Contract.Dtos;
using ProShop.Contract.Requests;
using ProShop.Core.Exceptions;
using ProShop.Users.App.Tests.Unit.Fakes;
using ProShop.Users.App.UseCases;
using ProShop.Users.Domain.Tests.Unit.Fakes;
using System;

namespace ProShop.Users.App.Tests.Unit.UseCases
{
    [TestClass]
    [TestCategory("Unit")]
    public class SignInUserCommandTests
    {
        private SignInUserCommand _sut;

        private SignInUserRequest _request;

        [TestInitialize]
        public void Initialize()
        {
            _request = new SignInUserRequest
            {
                Email = "FirstName.LastName@example.com",
            };
        }

        [TestMethod]
        public void Able_to_create_instance()
        {
            CreateSut();

            _sut.Should().NotBeNull();
        }

        [TestMethod]
        public void Execute_returns_user_when_password_is_matching_for_existing_user()
        {
            _request.Password = "password";
            CreateSut();

            UserDto actual = _sut.Execute().Result;

            UserDto expected = MockUserDtoBuilder.Build();

            actual.Should().BeEquivalentTo(expected);
        }

        [TestMethod]
        public void Execute_throws_exception_when_password_is_not_matching_for_existing_user()
        {
            _request.Password = "wrongpassword";
            CreateSut();

            Action action = ()
                => _sut.Execute().Wait();

            action.Should().Throw<InvalidUserCredentialsException>();
        }

        private void CreateSut()
        {
            _sut = new SignInUserCommand(
                _request,
                new FakeUserRepository { ReturnsSingle = MockUserBuilder.Build() });
        }
    }
}
