using System;
using System.Threading.Tasks;

namespace ProShop.Core.Services
{
    public interface IRepository<T>
    {
        Task<T> Get(Guid id);
        Task Add(T entity);
        Task Update(T entity);
    }
}
