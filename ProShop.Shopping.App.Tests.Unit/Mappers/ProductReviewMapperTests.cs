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
