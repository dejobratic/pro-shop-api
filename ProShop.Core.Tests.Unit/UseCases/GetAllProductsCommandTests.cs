﻿using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProShop.Contract.Dtos;
using ProShop.Contract.Requests;
using ProShop.Core.Models;
using ProShop.Core.Tests.Unit.Fakes;
using ProShop.Core.UseCases;
using System;
using System.Collections.Generic;

namespace ProShop.Core.Tests.Unit.UseCases
{
    [TestClass]
    [TestCategory("Unit")]
    public class GetAllProductsCommandTests
    {
        private GetAllProductsCommand _sut;

        private static readonly Guid Product1Id
            = Guid.NewGuid();

        private static readonly Guid Product2Id
            = Guid.NewGuid();

        [TestInitialize]
        public void Initialize()
        {
            _sut = new GetAllProductsCommand(
                new GetAllProductsRequest(),
                new FakeProductRepository
                {
                    ReturnsMany = new Product[]
                    {
                        MockProductBuilder.Build(id: Product1Id),
                        MockProductBuilder.Build(id: Product2Id),
                    }
                });
        }

        [TestMethod]
        public void Execute_returns_all_products()
        {
            IEnumerable<ProductDto> actual = _sut.Execute().Result;
            IEnumerable<ProductDto> expected = new[]
            {
                MockProductDtoBuilder.Build(id: Product1Id),
                MockProductDtoBuilder.Build(id: Product2Id),
            };

            actual.Should().BeEquivalentTo(expected);
        }
    }
}
