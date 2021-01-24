﻿using ProShop.Shopping.App.Services;
using ProShop.Shopping.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProShop.Shopping.App.Tests.Unit.Fakes
{
    public class FakeProductRepository :
        IProductRepository
    {
        public Product ReturnsSingle { get; set; }
        public IEnumerable<Product> ReturnsMany { get; set; }

        public Task Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public async Task<Product> Get(Guid id)
        {
            return await Task.FromResult(ReturnsSingle);
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            return await Task.FromResult(ReturnsMany);
        }

        public Task Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}