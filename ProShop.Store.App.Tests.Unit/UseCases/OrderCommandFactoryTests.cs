using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProShop.Contract.Requests;
using ProShop.Core.UseCases;
using ProShop.Store.App.Tests.Unit.Fakes;
using ProShop.Store.App.UseCases;
using ProShop.Store.Contract.Dtos;
using ProShop.Store.Contract.Requests;
using System;
using System.Collections.Generic;

namespace ProShop.Store.App.Tests.Unit.UseCases
{
    [TestClass]
    [TestCategory("Unit")]
    public class OrderCommandFactoryTests
    {
        private OrderCommandFactory _sut;

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
        public void Create_without_return_type_should_create_CreateOrderCommand()
        {
            var request = new CreateOrderRequest();

            ICommand actual = _sut.Create(request);
            actual.Should().BeOfType(typeof(CreateOrderCommand));
        }

        [TestMethod]
        public void Create_without_return_type_should_throw_exception_when_called_with_unsupported_request()
        {
            Action action = ()
                => _sut.Create(new object() as IRequest);

            action.Should().Throw<Exception>()
                .WithMessage("Unable to create order command.");
        }

        [TestMethod]
        public void Create_with_return_type_should_create_GetOrderByIdCommand()
        {
            var request = new GetOrderByIdRequest();

            ICommand<OrderDto> actual = _sut.Create<OrderDto>(request);
            actual.Should().BeOfType(typeof(GetOrderByIdCommand));
        }

        [TestMethod]
        public void Create_with_return_type_should_create_GetOrdersByCustomerIdCommand()
        {
            var request = new GetOrdersByCustomerIdRequest();

            ICommand<IEnumerable<OrderDto>> actual = _sut.Create<IEnumerable<OrderDto>>(request);
            actual.Should().BeOfType(typeof(GetOrdersByCustomerIdCommand));
        }


        [TestMethod]
        public void Create_with_return_type_should_throw_exception_when_called_with_unsupported_request()
        {
            Action action = ()
                => _sut.Create<object>(new object() as IRequest);

            action.Should().Throw<Exception>()
                .WithMessage("Unable to create order command.");
        }

        private void CreateSut()
        {
            _sut = new OrderCommandFactory(
                new FakeOrderRepository());
        }
    }
}
