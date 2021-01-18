using ProShop.Orders.App.Services;
using ProShop.Orders.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProShop.Orders.App.Tests.Unit.Fakes
{
    public class FakeOrderRepository :
        IOrderRepository
    {
        public Order ReturnsSingle { get; set; }
        public IEnumerable<Order> ReturnsMultiple { get; set; }

        public Task Add(Order entity)
        {
            throw new NotImplementedException();
        }

        public async Task<Order> Get(Guid id)
        {
            return await Task.FromResult(ReturnsSingle);
        }

        public Task<IEnumerable<Order>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Order>> GetByCustomerId(Guid userId)
        {
            return await Task.FromResult(ReturnsMultiple);
        }

        public Task Update(Order entity)
        {
            throw new NotImplementedException();
        }
    }
}
