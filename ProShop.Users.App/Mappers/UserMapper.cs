using ProShop.Users.Contract.Dtos;
using ProShop.Users.Domain.Models;

namespace ProShop.Users.App.Mappers
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
                LastName = user.LastName
            };
        }
    }
}
