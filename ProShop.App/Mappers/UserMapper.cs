using ProShop.Contract.Dtos;
using ProShop.Core.Models;

namespace ProShop.App.Mappers
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
