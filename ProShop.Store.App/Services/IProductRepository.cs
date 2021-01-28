using ProShop.Core.Services;
using ProShop.Store.Domain.Models;

namespace ProShop.Store.App.Services
{
    public interface IProductRepository :
        IRepository<Product>
    {
    }
}
