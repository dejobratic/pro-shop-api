using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProShop.Orders.Domain.Models;

namespace ProShop.Orders.Domain.Tests.Unit.Models
{
    [TestClass]
    [TestCategory("Unit")]
    public class AddressTests
    {
        [TestMethod]
        public void Able_to_create_instance()
        {
            var expectedStreetLine1 = "StreetLine1";
            var expectedStreetLine2 = "StreetLine2";
            var expectedCity = "City";
            var expectedStateOrProvince = "StateOrProvince";
            var expectedPostalCode = "PostalCode";
            var expectedCountry = "Country";

            var sut = new Address(
                expectedStreetLine1,
                expectedStreetLine2,
                expectedCity,
                expectedStateOrProvince,
                expectedPostalCode,
                expectedCountry);

            sut.StreetLine1.Should().Be(expectedStreetLine1);
            sut.StreetLine2.Should().Be(expectedStreetLine2);
            sut.City.Should().Be(expectedCity);
            sut.PostalCode.Should().Be(expectedPostalCode);
            sut.Country.Should().Be(expectedCountry);
        }
    }
}
