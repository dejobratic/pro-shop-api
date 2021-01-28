using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProShop.Store.App.Mappers;
using ProShop.Store.App.Tests.Unit.Fakes;
using ProShop.Store.Contract.Dtos;
using ProShop.Store.Domain.Models;
using ProShop.Store.Domain.Tests.Unit.Fakes;

namespace ProShop.Store.App.Tests.Unit.Mappers
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
