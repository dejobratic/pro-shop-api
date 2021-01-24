using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProShop.Core.Exceptions;
using ProShop.Auth.App.Tests.Unit.Fakes;
using ProShop.Auth.App.UseCases;
using ProShop.Auth.Contract.Dtos;
using ProShop.Auth.Contract.Requests;
using ProShop.Auth.Domain.Tests.Unit.Fakes;
using System;

namespace ProShop.Auth.App.Tests.Unit.UseCases
{
    [TestClass]
    [TestCategory("Unit")]
    public class SignUpUserCommandTests
    {
        private SignUpUserCommand _sut;
        private FakeUserRepository _userRepo;

        private SignUpUserRequest _request;

        [TestInitialize]
        public void Initialize()
        {
            _userRepo = new FakeUserRepository();

            _request = new SignUpUserRequest
            {
                FirstName = "FirstName",
                LastName = "LastName",
                Email = "FirstName.LastName@example.com",
                Password = "password"
            };
        }

        [TestMethod]
        public void Able_to_create_instance()
        {
            CreateSut();

            _sut.Should().NotBeNull();
        }

        [TestMethod]
        public void Execute_registers_new_user()
        {
            _userRepo.ThrowsOnGet = new EntityNotFoundException();
            CreateSut();

            UserDto actual = _sut.Execute().Result;
            UserDto expected = MockUserDtoBuilder.Build();

            actual.Should().BeEquivalentTo(expected,
                opt => opt.Excluding(obj => obj.Id));

            _userRepo.Saved.FirstName.Should().Be(_request.FirstName);
            _userRepo.Saved.LastName.Should().Be(_request.LastName);
            _userRepo.Saved.Credentials.Email.Should().Be(_request.Email);
        }

        [TestMethod]
        public void Execute_throws_exception_when_user_with_same_email_already_exists()
        {
            _userRepo.ReturnsSingle = MockUserBuilder.Build();
            CreateSut();

            Action action = ()
                => _sut.Execute().Wait();

            action.Should().Throw<UserAlreadyExistsException>();
        }

        private void CreateSut()
        {
            _sut = new SignUpUserCommand(
                _request,
                _userRepo);
        }
    }
}
