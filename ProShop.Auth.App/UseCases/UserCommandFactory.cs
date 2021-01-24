using ProShop.Auth.App.Services;
using ProShop.Auth.Contract.Requests;
using ProShop.Contract.Requests;
using ProShop.Core.UseCases;
using System;

namespace ProShop.Auth.App.UseCases
{
    public class UserCommandFactory :
        IUserCommandFactory
    {
        private readonly IUserRepository _userRepo;
        private readonly ITokenGenerator _tokenGenerator;

        public UserCommandFactory(
            IUserRepository userRepo, 
            ITokenGenerator tokenGenerator)
        {
            _userRepo = userRepo;
            _tokenGenerator = tokenGenerator;
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
                        _userRepo,
                        _tokenGenerator) as ICommand<T>;

                case SignUpUserRequest signUpUserRequest:
                    return new SignUpUserCommand(
                        signUpUserRequest,
                        _userRepo,
                        _tokenGenerator) as ICommand<T>;

                default:
                    throw new Exception("Unable to create user command.");
            }
        }
    }
}
