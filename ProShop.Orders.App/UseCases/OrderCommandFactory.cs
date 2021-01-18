using ProShop.Contract.Requests;
using ProShop.Core.UseCases;
using ProShop.Orders.App.Services;
using ProShop.Orders.Contract.Requests;
using System;

namespace ProShop.Orders.App.UseCases
{
    public class OrderCommandFactory :
        IOrderCommandFactory
    {
        private readonly IOrderRepository _orderRepo;

        public OrderCommandFactory(
            IOrderRepository orderRepo)
        {
            _orderRepo = orderRepo;
        }

        public ICommand Create(IRequest request)
        {
            throw new NotImplementedException();
        }

        public ICommand<T> Create<T>(IRequest request)
        {
            switch (request)
            {
                case GetOrderByIdRequest getOrderByIdRequest:
                    return new GetOrderByIdCommand(
                        getOrderByIdRequest,
                        _orderRepo) as ICommand<T>;

                case GetOrdersByCustomerIdRequest getOrdersByCustomerIdRequest:
                    return new GetOrdersByCustomerIdCommand(
                        getOrdersByCustomerIdRequest,
                        _orderRepo) as ICommand<T>;

                default:
                    throw new Exception("Unable to create order command.");
            }
        }
    }
}
