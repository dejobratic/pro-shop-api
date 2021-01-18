using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProShop.Orders.App.Tests.Unit.Fakes;
using ProShop.Orders.App.UseCases;
using ProShop.Orders.Contract.Dtos;
using ProShop.Orders.Contract.Requests;
using ProShop.Orders.Domain.Tests.Unit.Fakes;

namespace ProShop.Orders.App.Tests.Unit.UseCases
{
    [TestClass]
    [TestCategory("Unit")]
    public class GetOrderByIdCommandTests
    {
        private GetOrderByIdCommand _sut;

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
        public void Execute_gets_order_by_id()
        {
            OrderDto actual = _sut.Execute().Result;
            OrderDto expected = MockOrderDtoBuilder.Build();

            actual.Should().BeEquivalentTo(expected);
        }

        private void CreateSut()
        {
            _sut = new GetOrderByIdCommand(
                new GetOrderByIdRequest(),
                new FakeOrderRepository { ReturnsSingle = MockOrderBuilder.Build() });
        }
    }
}
