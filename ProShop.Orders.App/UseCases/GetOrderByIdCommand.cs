using ProShop.Core.UseCases;
using ProShop.Orders.App.Mappers;
using ProShop.Orders.App.Services;
using ProShop.Orders.Contract.Dtos;
using ProShop.Orders.Contract.Requests;
using ProShop.Orders.Domain.Models;
using System.Threading.Tasks;

namespace ProShop.Orders.App.UseCases
{
    public class GetOrderByIdCommand :
        ICommand<OrderDto>
    {
        private readonly GetOrderByIdRequest _request;
        private readonly IOrderRepository _orderRepo;

        public GetOrderByIdCommand(
            GetOrderByIdRequest request, 
            IOrderRepository orderRepo)
        {
            _request = request;
            _orderRepo = orderRepo;
        }

        public async Task<OrderDto> Execute()
        {
            Order order = await _orderRepo.Get(_request.OrderId);
            return order.ToContractModel();
        }
    }
}
