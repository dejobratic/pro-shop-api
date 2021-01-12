using ProShop.Core.Services;
using ProShop.Products.Domain.Models;

namespace ProShop.Products.App.Services
{
    public interface IProductRepository :
        IRepository<Product>
    {
    }
}
