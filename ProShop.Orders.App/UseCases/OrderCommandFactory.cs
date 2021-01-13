using ProShop.Contract.Requests;
using ProShop.Core.UseCases;
using System;

namespace ProShop.Orders.App.UseCases
{
    public class OrderCommandFactory :
        IOrderCommandFactory
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
