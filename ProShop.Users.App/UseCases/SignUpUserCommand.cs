﻿using ProShop.Core.Exceptions;
using ProShop.Core.UseCases;
using ProShop.Users.App.Mappers;
using ProShop.Users.App.Services;
using ProShop.Users.Contract.Dtos;
using ProShop.Users.Contract.Requests;
using ProShop.Users.Domain.Models;
using System.Threading.Tasks;

namespace ProShop.Users.App.UseCases
{
    public class SignUpUserCommand :
        ICommand<UserDto>
    {
        private readonly SignUpUserRequest _request;
        private readonly IUserRepository _userRepo;

        public SignUpUserCommand(
            SignUpUserRequest request,
            IUserRepository userRepo)
        {
            _request = request;
            _userRepo = userRepo;
        }

        public async Task<UserDto> Execute()
        {
            await ThrowIfUserAlreadyExists();

            User user = CreateUser();
            await _userRepo.Add(user);

            return user.ToContractModel();
        }

        private async Task ThrowIfUserAlreadyExists()
        {
            try
            {
                await _userRepo.GetByEmail(_request.Email);
                throw new UserAlreadyExistsException();
            }
            catch (EntityNotFoundException) { }
        }

        private User CreateUser()
        {
            return new User(
                _request.FirstName,
                _request.LastName,
                CreateCredentials());
        }

        private UserCredentials CreateCredentials()
        {
            return new UserCredentials(
                _request.Email,
                _request.Password);
        }
    }
}
