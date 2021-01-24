using ProShop.Core.UseCases;
using ProShop.Orders.App.Mappers;
using ProShop.Orders.App.Services;
using ProShop.Orders.Contract.Requests;
using ProShop.Orders.Domain.Models;
using System.Threading.Tasks;

namespace ProShop.Orders.App.UseCases
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
            Order order = _request.Order.ToDomainModel();
            await _orderRepo.Add(order);
        }
    }
}
