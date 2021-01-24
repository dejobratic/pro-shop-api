using ProShop.Core.Services;
using ProShop.Shopping.Domain.Models;

namespace ProShop.Shopping.App.Services
{
    public interface IProductRepository :
        IRepository<Product>
    {
    }
}
