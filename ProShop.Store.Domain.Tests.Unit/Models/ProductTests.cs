using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProShop.Store.Domain.Models;
using System;

namespace ProShop.Store.Domain.Tests.Unit.Models
{
    [TestClass]
    [TestCategory("Unit")]
    public class ProductTests
    {
        [TestMethod]
        public void Able_to_create_instance_with_app_constructor()
        {
            var expectedName = "Name";
            var expectedBrand = "Brand";
            var expectedCategory = "Category";
            var expectedDescription = "Description";
            var expectedPrice = 0.99m;
            var expectedQuantityInStock = 100;
            var expectedReviews = new ProductReview[] { };

            var sut = new Product(
                expectedName,
                expectedBrand,
                expectedCategory,
                expectedDescription,
                expectedPrice,
                expectedQuantityInStock,
                expectedReviews);

            sut.Id.Should().NotBeEmpty();
            sut.Name.Should().Be(expectedName);
            sut.Brand.Should().Be(expectedBrand);
            sut.Description.Should().Be(expectedDescription);
            sut.Price.Should().Be(expectedPrice);
            sut.QuantityInStock.Should().Be(expectedQuantityInStock);
            sut.Reviews.Should().BeEquivalentTo(expectedReviews);
        }

        [TestMethod]
        public void Able_to_create_instance_with_persistence_constructor()
        {
            var expectedId = Guid.NewGuid();
            var expectedName = "Name";
            var expectedBrand = "Brand";
            var expectedCategory = "Category";
            var expectedDescription = "Description";
            var expectedPrice = 0.99m;
            var expectedQuantityInStock = 100;
            var expectedReviews = new ProductReview[] { };

            var sut = new Product(
                expectedId,
                expectedName,
                expectedBrand,
                expectedCategory,
                expectedDescription,
                expectedPrice,
                expectedQuantityInStock,
                expectedReviews);

            sut.Id.Should().Be(expectedId);
            sut.Name.Should().Be(expectedName);
            sut.Brand.Should().Be(expectedBrand);
            sut.Description.Should().Be(expectedDescription);
            sut.Price.Should().Be(expectedPrice);
            sut.QuantityInStock.Should().Be(expectedQuantityInStock);
            sut.Reviews.Should().BeEquivalentTo(expectedReviews);
        }
    }
}
