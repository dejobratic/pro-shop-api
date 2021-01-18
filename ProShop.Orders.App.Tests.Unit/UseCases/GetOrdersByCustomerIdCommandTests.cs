using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProShop.Orders.App.Tests.Unit.Fakes;
using ProShop.Orders.App.UseCases;
using ProShop.Orders.Contract.Dtos;
using ProShop.Orders.Contract.Requests;
using ProShop.Orders.Domain.Models;
using ProShop.Orders.Domain.Tests.Unit.Fakes;
using System;
using System.Collections.Generic;

namespace ProShop.Orders.App.Tests.Unit.UseCases
{
    [TestClass]
    [TestCategory("Unit")]
    public class GetOrdersByCustomerIdCommandTests
    {
        private GetOrdersByCustomerIdCommand _sut;

        private static readonly Guid Order1Id
            = Guid.NewGuid();

        private static readonly Guid Order2Id
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
            IEnumerable<OrderDto> actual = _sut.Execute().Result;
            IEnumerable<OrderDto> expected = new[]
            {
                MockOrderDtoBuilder.Build(id: Order1Id),
                MockOrderDtoBuilder.Build(id: Order2Id),
            };

            actual.Should().BeEquivalentTo(expected);
        }

        private void CreateSut()
        {
            _sut = new GetOrdersByCustomerIdCommand(
                new GetOrdersByCustomerIdRequest(),
                new FakeOrderRepository
                {
                    ReturnsMultiple = new Order[]
                    {
                        MockOrderBuilder.Build(id: Order1Id),
                        MockOrderBuilder.Build(id: Order2Id),
                    }
                });
        }
    }
}
