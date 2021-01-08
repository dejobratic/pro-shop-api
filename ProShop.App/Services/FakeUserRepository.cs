using ProShop.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProShop.App.Services
{
    public class FakeUserRepository :
        IUserRepository
    {
        private readonly Dictionary<Guid, User> _userSet
            = new Dictionary<Guid, User>
            {
                {
                    new Guid("657D2C04-9FF1-4144-84FA-1D1065B411EB"),
                    new User(
                        new Guid("657D2C04-9FF1-4144-84FA-1D1065B411EB"),
                        "John",
                        "Doe",
                        null)
                },
                {
                    new Guid("98329125-D18B-462D-82F7-6096BFE32E02"),
                    new User(
                        new Guid("98329125-D18B-462D-82F7-6096BFE32E02"),
                        "Jane",
                        "Smith",
                        null)
                }
            };

        public Task Add(User entity)
        {
            throw new NotImplementedException();
        }

        public async Task<User> Get(Guid id)
        {
            return await Task.FromResult(_userSet[id]);
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await Task.FromResult(_userSet.Values);
        }

        public async Task<User> GetByEmail(string email)
        {
            return await Task.FromResult(_userSet.Values.First());
        }

        public Task Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
