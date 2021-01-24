using ProShop.Core.UseCases;
using ProShop.Shopping.App.Mappers;
using ProShop.Shopping.App.Services;
using ProShop.Shopping.Contract.Dtos;
using ProShop.Shopping.Contract.Requests;
using ProShop.Shopping.Domain.Models;
using System.Threading.Tasks;

namespace ProShop.Shopping.App.UseCases
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
