using ProShop.App.Mappers;
using ProShop.App.Services;
using ProShop.Contract.Dtos;
using ProShop.Contract.Requests;
using ProShop.Core.Exceptions;
using ProShop.Core.Models;
using ProShop.Core.UseCases;
using System.Threading.Tasks;

namespace ProShop.App.UseCases
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
