using ProShop.Core.UseCases;
using ProShop.Shopping.App.Mappers;
using ProShop.Shopping.App.Services;
using ProShop.Shopping.Contract.Requests;
using ProShop.Shopping.Domain.Models;
using System.Threading.Tasks;

namespace ProShop.Shopping.App.UseCases
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
