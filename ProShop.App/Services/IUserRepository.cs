using ProShop.Core.Models;
using ProShop.Core.Services;
using System.Threading.Tasks;

namespace ProShop.App.Services
{
    public interface IUserRepository :
        IRepository<User>
    {
        Task<User> GetByEmail(string email);
    }
}
