using ProShop.Core.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProShop.App.Services
{
    public class FakeProductRepository :
        IProductRepository
    {
        private readonly Dictionary<Guid, Product> _productSet
            = new Dictionary<Guid, Product>
            {
                {
                    new Guid("82D99C3F-8870-4F9B-8807-566F4DC11E6B"),
                    new Product(
                        new Guid("82D99C3F-8870-4F9B-8807-566F4DC11E6B"),
                        "Sony Playstation 4 Pro White Version",
                        "Sony",
                        "Electronics",
                        "The ultimate home entertainment center starts with PlayStation. Whether you are into gaming, HD movies, television, music...",
                        399.99m,
                        12,
                        new ProductReview[] {})
                },
                {
                    new Guid("A5A2D7A9-0134-4604-850F-34F57B1DB097"),
                    new Product(
                        new Guid("A5A2D7A9-0134-4604-850F-34F57B1DB097"),
                        "Logitech G-Series Gaming Mouse",
                        "Logitech",
                        "Electronics",
                        "Get a better handle on your games with this Logitech LIGHTSYNC gaming mouse. The six programmable buttons allow customization for a smooth playing experience...",
                        49.99m,
                        8,
                        new ProductReview[] {})
                },
            };

        public Task Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public async Task<Product> Get(Guid id)
        {
            return await Task.FromResult(_productSet[id]);
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            return await Task.FromResult(_productSet.Values);
        }

        public Task Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
