using ProShop.Store.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProShop.Store.App.Services
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
                        new []
                        {
                            new OrderItem(
                                new Guid("348C5840-64FF-49AA-A9A7-446A789F61D5"),
                                new Guid("82D99C3F-8870-4F9B-8807-566F4DC11E6B"),
                                1,
                                399.99m)
                        },
                        new Address(
                            "3500 Deer Creek Rd",
                            "",
                            "Palo Alto",
                            "CA",
                            "94304",
                            "US"),
                        new Guid("657D2C04-9FF1-4144-84FA-1D1065B411EB"))
                },
                {
                    new Guid("46EE7851-00C1-41B6-B108-7AC5B23296AE"),
                    new Order(
                        new Guid("46EE7851-00C1-41B6-B108-7AC5B23296AE"),
                        new []
                        {
                            new OrderItem(
                                new Guid("348C5840-64FF-49AA-A9A7-446A789F61D5"),
                                new Guid("A5A2D7A9-0134-4604-850F-34F57B1DB097"),
                                3,
                                399.99m)
                        },
                        new Address(
                            "1 Apple Park Way",
                            "",
                            "Cupertino",
                            "CA",
                            "95014",
                            "US"),
                        new Guid("98329125-D18B-462D-82F7-6096BFE32E02"))
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

        public async Task<IEnumerable<Order>> GetByCustomerId(Guid customerId)
        {
            var orders = _orderSet.Values.Where(o => o.Customer == customerId);
            return await Task.FromResult(orders);
        }

        public Task Update(Order entity)
        {
            throw new NotImplementedException();
        }
    }
}
