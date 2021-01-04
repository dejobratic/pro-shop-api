using ProShop.Core.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProShop.Core.Services
{
    public class FakeProductRepository :
        IProductRepository
    {
        private readonly Dictionary<Guid, Product> _productSet
            = new Dictionary<Guid, Product>
            {
                {
                    new Guid("82D99C3F-8870-4F9B-8807-566F4DC11E6B"),
                    new Product
                    {
                        Id = new Guid("82D99C3F-8870-4F9B-8807-566F4DC11E6B"),
                        Name = "Sony Playstation 4 Pro White Version",
                        Brand = "Sony",
                        Category = "Electronics",
                        Description = "The ultimate home entertainment center starts with PlayStation. Whether you are into gaming, HD movies, television, music...",
                        Price = 399.99m,
                        QuantityInStock = 12,
                        Reviews = new ProductReview[] {}
                    }
                },
                {
                    new Guid("A5A2D7A9-0134-4604-850F-34F57B1DB097"),
                    new Product
                    {
                        Id = new Guid("A5A2D7A9-0134-4604-850F-34F57B1DB097"),
                        Name = "Logitech G-Series Gaming Mouse",
                        Brand = "Logitech",
                        Category = "Electronics",
                        Description = "Get a better handle on your games with this Logitech LIGHTSYNC gaming mouse. The six programmable buttons allow customization for a smooth playing experience...",
                        Price = 49.99m,
                        QuantityInStock = 8,
                        Reviews = new ProductReview[] {}
                    }
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
