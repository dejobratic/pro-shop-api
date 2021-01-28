using ProShop.Core.Services;
using ProShop.Store.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProShop.Store.App.Services
{
    public interface IOrderRepository :
        IRepository<Order>
    {
        Task<IEnumerable<Order>> GetByCustomerId(Guid customerId);
    }
}
