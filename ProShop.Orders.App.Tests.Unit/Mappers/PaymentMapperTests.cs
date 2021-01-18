using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProShop.Orders.App.Mappers;
using ProShop.Orders.App.Tests.Unit.Fakes;
using ProShop.Orders.Contract.Dtos;
using ProShop.Orders.Domain.Models;
using ProShop.Orders.Domain.Tests.Unit.Fakes;

namespace ProShop.Orders.App.Tests.Unit.Mappers
{
    [TestClass]
    [TestCategory("Unit")]
    public class PaymentMapperTests
    {
        [TestMethod]
        public void ToContractModel_maps_domain_payment_to_contract_model()
        {
            Payment payment = MockPaymentBuilder.Build();

            PaymentDto actual = payment.ToContractModel();
            PaymentDto expected = MockPaymentDtoBuilder.Build();

            actual.Should().BeEquivalentTo(expected);
        }
    }
}
