using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProShop.Shopping.App.Tests.Unit.Fakes;
using ProShop.Shopping.App.UseCases;
using ProShop.Shopping.Contract.Dtos;
using ProShop.Shopping.Contract.Requests;
using ProShop.Shopping.Domain.Tests.Unit.Fakes;

namespace ProShop.Shopping.App.Tests.Unit.UseCases
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
