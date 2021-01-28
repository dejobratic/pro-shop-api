using ProShop.Core.UseCases;
using ProShop.Store.App.Mappers;
using ProShop.Store.App.Services;
using ProShop.Store.Contract.Requests;
using ProShop.Store.Domain.Models;
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
            Order order = _request.Order.ToDomainModel();
            await _orderRepo.Add(order);
        }
    }
}
