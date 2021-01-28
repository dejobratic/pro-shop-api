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
    public class SignUpUserCommand :
        ICommand<UserDto>
    {
        private readonly SignUpUserRequest _request;
        private readonly IUserRepository _userRepo;
        private readonly ITokenGenerator _tokenGenerator;

        public SignUpUserCommand(
            SignUpUserRequest request,
            IUserRepository userRepo, 
            ITokenGenerator tokenGenerator)
        {
            _request = request;
            _userRepo = userRepo;
            _tokenGenerator = tokenGenerator;
        }

        public async Task<UserDto> Execute()
        {
            await ThrowIfUserAlreadyExists();

            User user = CreateUser();
            await _userRepo.Add(user);

            var token = _tokenGenerator.Generate(user);
            return user.ToContractModel().WithToken(token);
        }

        private async Task ThrowIfUserAlreadyExists()
        {
            try
            {
                await _userRepo.GetByEmail(_request.Email);
                throw new EntityAlreadyExistsException(typeof(User));
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
