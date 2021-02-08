using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProShop.Billing.App.UseCases;
using System;

namespace ProShop.Billing.App.Tests.Unit.UseCases
{
    [TestClass]
    [TestCategory("Unit")]
    public class CreatePaymentCommandTests
    {
        private readonly CreatePaymentCommand _sut;

        [TestInitialize]
        public void Initialize()
        {
            CreateSut();
        }

        [TestMethod]
        public void Able_to_create_instance()
        {
        }

        private void CreateSut()
        {
            throw new NotImplementedException();
        }
    }
}
