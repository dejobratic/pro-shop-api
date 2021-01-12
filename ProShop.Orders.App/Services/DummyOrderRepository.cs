using ProShop.Orders.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProShop.Orders.App.Services
{
    public class DummyOrderRepository :
        IOrderRepository
    {
        private readonly Dictionary<Guid, Order> _orderSet
            = new Dictionary<Guid, Order>
            {
                {
                    new Guid("2B4083A4-8963-4798-AFAE-641840890A13"),
                    new Order(
                        new Guid("2B4083A4-8963-4798-AFAE-641840890A13"),
                        null,
                        null)
                },
                {
                    new Guid("46EE7851-00C1-41B6-B108-7AC5B23296AE"),
                    new Order(
                        new Guid("46EE7851-00C1-41B6-B108-7AC5B23296AE"),
                        null,
                        null)
                }
            };

        public Task Add(Order entity)
        {
            throw new NotImplementedException();
        }

        public async Task<Order> Get(Guid id)
        {
            return await Task.FromResult(_orderSet[id]);
        }

        public async Task<IEnumerable<Order>> GetAll()
        {
            return await Task.FromResult(_orderSet.Values);
        }

        public Task Update(Order entity)
        {
            throw new NotImplementedException();
        }
    }
}
