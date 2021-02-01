using ProShop.Core.UseCases;
using ProShop.Store.App.Mappers;
using ProShop.Store.App.Services;
using ProShop.Store.Contract.Requests;
using ProShop.Store.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProShop.Store.App.UseCases
{
    public class CreateOrderCommand :
        ICommand
    {
        private readonly CreateOrderRequest _request;
        private readonly IOrderRepository _orderRepo;

        public CreateOrderCommand(
            CreateOrderRequest request,
            IOrderRepository orderRepo)
        {
            _request = request;
            _orderRepo = orderRepo;
        }

        public async Task Execute()
        {
            Order order = CreateOrder();
            await _orderRepo.Add(order);
        }

        private Order CreateOrder()
        {
            return new Order(
                CreateOrderItems(),
                CreateShippingAddress(),
                _request.Order.Customer);
        }

        private IEnumerable<OrderItem> CreateOrderItems()
        {
            foreach (var item in _request.Order.Items)
                yield return new OrderItem(
                    item.Product,
                    item.Quantity,
                    item.Price);
        }

        private Address CreateShippingAddress()
            => _request.Order.ShippingAddress.ToDomainModel();
    }
}
