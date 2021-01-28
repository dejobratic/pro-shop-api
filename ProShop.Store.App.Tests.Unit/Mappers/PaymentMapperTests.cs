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
    public class PaymentMapperTests
    {
        [TestMethod]
        public void ToDomainModel_maps_contract_payment_to_domain_model()
        {
            PaymentDto payment = MockPaymentDtoBuilder.Build();

            Payment actual = payment.ToDomainModel();
            Payment expected = MockPaymentBuilder.Build();

            actual.Should().BeEquivalentTo(expected);
        }


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
