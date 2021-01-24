using ProShop.Auth.Contract.Dtos;
using ProShop.Auth.Domain.Models;

namespace ProShop.Auth.App.Mappers
{
    public static class UserMapper
    {
        public static UserDto ToContractModel(
            this User user)
        {
            return new UserDto
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Credentials.Email
            };
        }
    }
}
