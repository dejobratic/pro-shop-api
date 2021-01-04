using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProShop.App.Tests.Unit.Fakes;
using ProShop.App.UseCases;
using ProShop.Contract.Dtos;
using ProShop.Contract.Requests;
using ProShop.Core.Tests.Unit.Fakes;

namespace ProShop.Core.Tests.Unit.UseCases
{
    [TestClass]
    [TestCategory("Unit")]
    public class GetProductByIdCommandTests
    {
        private GetProductByIdCommand _sut;

        [TestInitialize]
        public void Initialize()
        {
            CreateSut();
        }

        [TestMethod]
        public void Execute_returns_product_by_id()
        {
            ProductDto actual = _sut.Execute().Result;

            ProductDto expected = MockProductDtoBuilder.Build();

            actual.Should().BeEquivalentTo(expected);
        }

        private void CreateSut()
        {
            _sut = new GetProductByIdCommand(
                new GetProductByIdRequest(),
                new FakeProductRepository { ReturnsSingle = MockProductBuilder.Build() });
        }
    }
}
