using ProShop.Core.Services;
using ProShop.Orders.Domain.Models;

namespace ProShop.Orders.App.Services
{
    public interface IOrderRepository :
        IRepository<Order>
    {
    }
}
