using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProShop.Contract.Dtos;
using ProShop.Products.App.Mappers;
using ProShop.Products.App.Tests.Unit.Fakes;
using ProShop.Products.Domain.Models;
using ProShop.Products.Domain.Tests.Unit.Fakes;

namespace ProShop.Products.App.Tests.Unit.Mappers
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
