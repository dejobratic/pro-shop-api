using ProShop.Auth.App.Models;
using ProShop.Auth.Contract.Dtos;
using ProShop.Auth.Domain.Models;

namespace ProShop.Auth.App.Services
{
    public interface ITokenGenerator
    {
        TokenDto Generate(User user);
    }
}
