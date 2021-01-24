using ProShop.Contract.Requests;
using ProShop.Core.UseCases;
using ProShop.Shopping.App.Services;
using ProShop.Shopping.Contract.Requests;
using System;

namespace ProShop.Shopping.App.UseCases
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
            switch (request)
            {
                case CreateOrderRequest createOrderRequest:
                    return new CreateOrderCommand(
                        createOrderRequest,
                        _orderRepo);

                default:
                    throw new Exception("Unable to create order command.");
            }
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
