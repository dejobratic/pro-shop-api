using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProShop.Core.Services
{
    public interface IRepository<T>
    {
        Task<T> Get(Guid id);
        Task<IEnumerable<T>> GetAll();
        Task Add(T entity);
        Task Update(T entity);
    }
}
