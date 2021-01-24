using ProShop.Core.Exceptions;
using ProShop.Core.UseCases;
using ProShop.Auth.App.Mappers;
using ProShop.Auth.App.Services;
using ProShop.Auth.Contract.Dtos;
using ProShop.Auth.Contract.Requests;
using ProShop.Auth.Domain.Models;
using System.Threading.Tasks;

namespace ProShop.Auth.App.UseCases
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
