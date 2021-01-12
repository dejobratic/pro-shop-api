using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProShop.Contract;
using ProShop.Contract.Dtos;
using ProShop.Contract.Requests;
using ProShop.Core.UseCases;
using ProShop.Users.App.Tests.Unit.Fakes;
using ProShop.Users.App.UseCases;
using System;

namespace ProShop.Users.App.Tests.Unit.UseCases
{
    [TestClass]
    [TestCategory("Unit")]
    public class UserCommandFactoryTests
    {
        private UserCommandFactory _sut;

        [TestInitialize]
        public void Initialize()
        {
            CreateSut();
        }

        [TestMethod]
        public void Able_to_create_instance()
        {
            _sut.Should().NotBeNull();
        }

        [TestMethod]
        public void Create_without_return_type_should_throw_exception()
        {
            Action action = ()
                => _sut.Create(new object() as IRequest);

            action.Should().Throw<NotImplementedException>();
        }

        [TestMethod]
        public void Create_with_return_type_should_create_SignInUserCommand()
        {
            var request = new SignInUserRequest();

            ICommand<UserDto> actual = _sut.Create<UserDto>(request);
            actual.Should().BeOfType(typeof(SignInUserCommand));
        }

        [TestMethod]
        public void Create_with_return_type_should_create_SignUpUserCommand()
        {
            var request = new SignUpUserRequest();

            ICommand<UserDto> actual = _sut.Create<UserDto>(request);
            actual.Should().BeOfType(typeof(SignUpUserCommand));
        }


        [TestMethod]
        public void Create_with_return_type_should_throw_exception_when_called_with_unsupported_request()
        {
            Action action = ()
                => _sut.Create<object>(new object() as IRequest);

            action.Should().Throw<Exception>()
                .WithMessage("Unable to create user command.");
        }

        private void CreateSut()
        {
            _sut = new UserCommandFactory(
                new FakeUserRepository());
        }
    }
}
