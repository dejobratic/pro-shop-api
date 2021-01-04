using ProShop.Core.Models;
using System;
using System.Collections.Generic;
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
                    new User
                    {
                        Id = new Guid("657D2C04-9FF1-4144-84FA-1D1065B411EB"),
                        FirstName = "John",
                        LastName = "Doe"
                    }
                },
                {
                    new Guid("98329125-D18B-462D-82F7-6096BFE32E02"),
                    new User
                    {
                        Id = new Guid("98329125-D18B-462D-82F7-6096BFE32E02"),
                        FirstName = "Jane",
                        LastName = "Smith"
                    }
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

        public Task Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
