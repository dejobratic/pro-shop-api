using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProShop.Contract.Dtos;
using ProShop.Contract.Requests;
using ProShop.Products.App.Tests.Unit.Fakes;
using ProShop.Products.App.UseCases;
using ProShop.Products.Domain.Models;
using ProShop.Products.Domain.Tests.Unit.Fakes;
using System;
using System.Collections.Generic;

namespace ProShop.Products.App.Tests.Unit.UseCases
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
            CreateSut();
        }

        [TestMethod]
        public void Able_to_create_instance()
        {
            _sut.Should().NotBeNull();
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

        private void CreateSut()
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
    }
}
