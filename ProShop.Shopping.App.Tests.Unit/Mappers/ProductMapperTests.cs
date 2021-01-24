using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProShop.Shopping.App.Mappers;
using ProShop.Shopping.App.Tests.Unit.Fakes;
using ProShop.Shopping.Contract.Dtos;
using ProShop.Shopping.Domain.Models;
using ProShop.Shopping.Domain.Tests.Unit.Fakes;

namespace ProShop.Shopping.App.Tests.Unit.Mappers
{
    [TestClass]
    [TestCategory("Unit")]
    public class ProductMapperTests
    {
        [TestMethod]
        public void ToContractModel_maps_domain_product_to_contract_model()
        {
            Product product = MockProductBuilder.Build();

            ProductDto actual = product.ToContractModel();
            ProductDto expected = MockProductDtoBuilder.Build();

            actual.Should().BeEquivalentTo(expected);
        }
    }
}
