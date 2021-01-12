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
    public class ProductReviewMapperTests
    {
        [TestMethod]
        public void ToContractModel_maps_domain_review_to_contract_model()
        {
            ProductReview review = MockProductReviewBuilder.Build();

            ProductReviewDto actual = review.ToContractModel();
            ProductReviewDto expected = MockProductReviewDtoBuilder.Build();

            actual.Should().BeEquivalentTo(expected);
        }
    }
}
