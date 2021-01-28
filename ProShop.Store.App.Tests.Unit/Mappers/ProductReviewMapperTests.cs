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
