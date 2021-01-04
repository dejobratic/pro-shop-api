using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProShop.App.Mappers;
using ProShop.App.Tests.Unit.Fakes;
using ProShop.Contract.Dtos;
using ProShop.Core.Models;
using ProShop.Core.Tests.Unit.Fakes;

namespace ProShop.Core.Tests.Unit.Mappers
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
