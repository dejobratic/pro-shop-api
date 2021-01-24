using ProShop.Auth.App.Services;
using ProShop.Auth.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProShop.Auth.App.Tests.Unit.Fakes
{
    public class FakeUserRepository :
        IUserRepository
    {
        public User ReturnsSingle { get; set; }
        public Exception ThrowsOnGet { get; set; }

        public User Saved { get; private set; }

        public async Task Add(User entity)
        {
            await Task.CompletedTask;
            Saved = entity;
        }

        public async Task<User> Get(Guid id)
        {
            if (ThrowsOnGet is { })
                throw ThrowsOnGet;

            return await Task.FromResult(ReturnsSingle);
        }

        public Task<IEnumerable<User>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetByEmail(string email)
        {
            if (ThrowsOnGet is { })
                throw ThrowsOnGet;

            return await Task.FromResult(ReturnsSingle);
        }

        public Task Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
