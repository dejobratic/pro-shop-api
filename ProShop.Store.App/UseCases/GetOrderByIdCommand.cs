using ProShop.Core.UseCases;
using ProShop.Store.App.Mappers;
using ProShop.Store.App.Services;
using ProShop.Store.Contract.Dtos;
using ProShop.Store.Contract.Requests;
using ProShop.Store.Domain.Models;
using System.Threading.Tasks;

namespace ProShop.Store.App.UseCases
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
