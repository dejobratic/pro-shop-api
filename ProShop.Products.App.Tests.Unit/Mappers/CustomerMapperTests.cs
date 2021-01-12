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
    public class CustomerMapperTests
    {
        [TestMethod]
        public void ToContractModel_maps_domain_customer_to_contract_model()
        {
            Customer customer = MockProductReviewerBuilder.Build();

            CustomerDto actual = customer.ToContractModel();
            CustomerDto expected = MockCustomerDtoBuilder.Build();

            actual.Should().BeEquivalentTo(expected);
        }
    }
}
