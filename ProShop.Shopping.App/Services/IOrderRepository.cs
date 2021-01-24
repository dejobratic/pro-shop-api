using ProShop.Core.Services;
using ProShop.Shopping.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProShop.Shopping.App.Services
{
    public interface IOrderRepository :
        IRepository<Order>
    {
        Task<IEnumerable<Order>> GetByCustomerId(Guid customerId);
    }
}
