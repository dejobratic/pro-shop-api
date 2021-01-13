using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProShop.Products.App.Tests.Unit.Fakes;
using ProShop.Products.App.UseCases;
using ProShop.Products.Contract.Dtos;
using ProShop.Products.Contract.Requests;
using ProShop.Products.Domain.Tests.Unit.Fakes;

namespace ProShop.Products.App.Tests.Unit.UseCases
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
        public void Able_to_create_instance()
        {
            _sut.Should().NotBeNull();
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
