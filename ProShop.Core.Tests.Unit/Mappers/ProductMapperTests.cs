using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProShop.Contract.Dtos;
using ProShop.Core.Mappers;
using ProShop.Core.Models;
using ProShop.Core.Tests.Unit.Fakes;

namespace ProShop.Core.Tests.Unit.Mappers
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
