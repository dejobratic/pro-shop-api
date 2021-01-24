﻿using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProShop.Orders.App.Tests.Unit.Fakes;
using ProShop.Orders.App.UseCases;
using ProShop.Orders.Domain.Models;
using ProShop.Orders.Domain.Tests.Unit.Fakes;
using System.Text.RegularExpressions;

namespace ProShop.Orders.App.Tests.Unit.UseCases
{
    [TestClass]
    [TestCategory("Unit")]
    public class CreateOrderCommandTests
    {
        private CreateOrderCommand _sut;
        private FakeOrderRepository _orderRepo;

        [TestInitialize]
        public void Initialize()
        {
            CreateSut();
        }

        [TestMethod]
        public void Able_to_create_instance()
        {
        }

        [TestMethod]
        public void Execute_creates_order()
        {
            _sut.Execute().Wait();

            Order actual = _orderRepo.Saved;
            Order expected = MockOrderBuilder.Build();

            actual.Should().BeEquivalentTo(expected, 
                opt => opt.Excluding(o => o.Id).Excluding(o => Regex.IsMatch(o.SelectedMemberPath, @"Children\[.+\]\.ID")));
        }

        private void CreateSut()
        {
            _sut = new CreateOrderCommand(
                MockCreateOrderRequestBuilder.Build(),
                _orderRepo = new FakeOrderRepository());
        }
    }
}
