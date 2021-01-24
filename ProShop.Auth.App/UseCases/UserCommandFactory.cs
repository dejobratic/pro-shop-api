using ProShop.Contract.Requests;
using ProShop.Core.UseCases;
using ProShop.Auth.App.Services;
using ProShop.Auth.Contract.Requests;
using System;

namespace ProShop.Auth.App.UseCases
{
    public class UserCommandFactory :
        IUserCommandFactory
    {
        private readonly IUserRepository _userRepo;

        public UserCommandFactory(
            IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        public ICommand Create(IRequest request)
        {
            throw new NotImplementedException();
        }

        public ICommand<T> Create<T>(IRequest request)
        {
            switch (request)
            {
                case SignInUserRequest signInUserRequest:
                    return new SignInUserCommand(
                        signInUserRequest,
                        _userRepo) as ICommand<T>;

                case SignUpUserRequest signUpUserRequest:
                    return new SignUpUserCommand(
                        signUpUserRequest,
                        _userRepo) as ICommand<T>;

                default:
                    throw new Exception("Unable to create user command.");
            }
        }
    }
}
