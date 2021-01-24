using ProShop.Core.Services;
using ProShop.Auth.Domain.Models;
using System.Threading.Tasks;

namespace ProShop.Auth.App.Services
{
    public interface IUserRepository :
        IRepository<User>
    {
        Task<User> GetByEmail(string email);
    }
}
