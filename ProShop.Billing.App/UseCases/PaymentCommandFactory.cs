using ProShop.Contract.Requests;
using ProShop.Core.UseCases;
using System;

namespace ProShop.Billing.App.UseCases
{
    public class PaymentCommandFactory :
        ICommandFactory
    {
        public ICommand Create(IRequest request)
        {
            throw new NotImplementedException();
        }

        public ICommand<T> Create<T>(IRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
