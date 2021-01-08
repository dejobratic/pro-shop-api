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

        private Credentials CreateCredentials()
        {
            return new Credentials(
                _request.Email,
                _request.Password);
        }
    }
}
