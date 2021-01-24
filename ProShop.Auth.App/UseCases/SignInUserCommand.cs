using ProShop.Auth.App.Extensions;
using ProShop.Auth.App.Mappers;
using ProShop.Auth.App.Services;
using ProShop.Auth.Contract.Dtos;
using ProShop.Auth.Contract.Requests;
using ProShop.Auth.Domain.Models;
using ProShop.Core.Exceptions;
using ProShop.Core.UseCases;
using System.Threading.Tasks;

namespace ProShop.Auth.App.UseCases
{
    public class SignInUserCommand :
       ICommand<UserDto>
    {
        private readonly SignInUserRequest _request;
        private readonly IUserRepository _userRepo;
        private readonly ITokenGenerator _tokenGenerator;

        public SignInUserCommand(
            SignInUserRequest request,
            IUserRepository userRepo, 
            ITokenGenerator tokenGenerator)
        {
            _request = request;
            _userRepo = userRepo;
            _tokenGenerator = tokenGenerator;
        }

        public async Task<UserDto> Execute()
        {
            User user = await _userRepo.GetByEmail(_request.Email);

            if (user.Credentials.IsMatchingPassword(_request.Password))
            {
                var token = _tokenGenerator.Generate(user);
                return user.ToContractModel().WithToken(token);
            }

            throw new InvalidUserCredentialsException();
        }
    }
}
