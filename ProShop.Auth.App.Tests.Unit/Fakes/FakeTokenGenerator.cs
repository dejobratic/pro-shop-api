using ProShop.Auth.App.Services;
using ProShop.Auth.Contract.Dtos;
using ProShop.Auth.Domain.Models;

namespace ProShop.Auth.App.Tests.Unit.Fakes
{
    public class FakeTokenGenerator :
        ITokenGenerator
    {
        public TokenDto Returns { get; set; }

        public TokenDto Generate(User user)
            => Returns;
    }
}
