using ProShop.Core.Services;
using ProShop.Users.Domain.Models;
using System.Threading.Tasks;

namespace ProShop.Users.App.Services
{
    public interface IUserRepository :
        IRepository<User>
    {
        Task<User> GetByEmail(string email);
    }
}
