using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProShop.Core.Tests.Unit.Helpers;
using ProShop.Shopping.Domain.Models;
using System;

namespace ProShop.Shopping.Domain.Tests.Unit.Models
{
    [TestClass]
    [TestCategory("Unit")]
    public class ProductReviewTests
    {
        [TestMethod]
        public void Able_to_create_instance()
        {
            var expectedId = Guid.NewGuid();
            var expectedTitle = "Title";
            var expectedComment = "Comment";
            var expectedRating = 4.5;
            var expectedCreatedAt = DateTime.UtcNow;
            var expectedCreatedBy = GuidProvider.UserId;

            var sut = new ProductReview(
                expectedId,
                expectedTitle,
                expectedComment,
                expectedRating,
                expectedCreatedAt,
                expectedCreatedBy);

            sut.Id.Should().Be(expectedId);
            sut.Title.Should().Be(expectedTitle);
            sut.Comment.Should().Be(expectedComment);
            sut.Rating.Should().Be(expectedRating);
            sut.CreatedAt.Should().Be(expectedCreatedAt);
            sut.CreatedBy.Should().Be(expectedCreatedBy);
        }
    }
}
