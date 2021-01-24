using ProShop.Auth.Contract.Dtos;

namespace ProShop.Auth.App.Extensions
{
    public static class UserExtensions
    {
        public static UserDto WithToken(
            this UserDto user,
            TokenDto token)
        {
            user.Token = token;
            return user;
        }
    }
}
