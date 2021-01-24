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
    public class SignInUserCommand :
       ICommand<UserDto>
    {
        private readonly SignInUserRequest _request;
        private readonly IUserRepository _userRepo;

        public SignInUserCommand(
            SignInUserRequest request,
            IUserRepository userRepo)
        {
            _request = request;
            _userRepo = userRepo;
        }

        public async Task<UserDto> Execute()
        {
            User user = await _userRepo.GetByEmail(_request.Email);

            if (user.Credentials.IsMatchingPassword(_request.Password))
                return user.ToContractModel();

            throw new InvalidUserCredentialsException();
        }
    }
}
