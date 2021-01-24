using ProShop.Shopping.App.Services;
using ProShop.Shopping.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProShop.Shopping.App.Tests.Unit.Fakes
{
    public class FakeOrderRepository :
        IOrderRepository
    {
        public Order ReturnsSingle { get; set; }
        public IEnumerable<Order> ReturnsMultiple { get; set; }
        public Order Saved { get; private set; }

        public async Task Add(Order entity)
        {
            await Task.CompletedTask;
            Saved = entity;
        }

        public async Task<Order> Get(Guid id)
        {
            return await Task.FromResult(ReturnsSingle);
        }

        public Task<IEnumerable<Order>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Order>> GetByCustomerId(Guid customerId)
        {
            return await Task.FromResult(ReturnsMultiple);
        }

        public Task Update(Order entity)
        {
            throw new NotImplementedException();
        }
    }
}
